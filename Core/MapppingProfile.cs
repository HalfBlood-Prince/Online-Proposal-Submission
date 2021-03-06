using AutoMapper;
using ProjectFinal101.Core.Models;
using ProjectFinal101.Core.Resources;

namespace ProjectFinal101.Core
{
    public class MapppingProfile : Profile
    {
        public MapppingProfile()
        {
            // resource to domain
            CreateMap<SemesterCreateResource, Semester>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.Parent, opt => opt.MapFrom(sr => sr.SemesterId))
                .ForMember(x => x.SemesterCatagories, opt => opt.Ignore())
                .AfterMap((semesterResource, semester) =>
                {
                    if (semesterResource.SemesterId >= 0) return;

                    foreach (var catagory in semesterResource.Catagories)
                    {
                        semester.SemesterCatagories.Add(new SemesterCatagory
                        {
                            MarksCatagory = new MarksCatagory
                            {
                                Name = catagory.Name,
                                Mark = catagory.Mark,
                                MarkType = catagory.MarkType
                            }
                        });
                    }

                });


            CreateMap<MarksCatagoryResource, MarksCatagory>();

            CreateMap<ProposalResource, Proposal>()
                .ForMember(x => x.ProposalTypeId, opt => opt.MapFrom(p => p.Type));

            CreateMap<ProposalWithOutNavResource, Proposal>()
                .ForMember(x => x.ProposalTypeId, opt => opt.MapFrom(p => p.Type));


            CreateMap<CourseResource, Course>()
                .ForMember(x => x.Id, opt => opt.Ignore());

            // domain to resource
            CreateMap<Semester, SemesterCreateResource>()
                .ForMember(x => x.Catagories, op => op.Ignore())
                .ForMember(x => x.SemesterId, opt => opt.MapFrom(s => s.Parent))
                .AfterMap(((semester, resource) =>
                {

                    foreach (var catagory in semester.SemesterCatagories)
                    {
                        var marksCatagoryResource = new MarksCatagoryResource { Id = catagory.MarksCatagoryId };

                        if (catagory.MarksCatagory != null)
                        {
                            marksCatagoryResource.Name = catagory.MarksCatagory.Name;
                            marksCatagoryResource.Mark = catagory.MarksCatagory.Mark;
                            marksCatagoryResource.MarkType = catagory.MarksCatagory.MarkType;
                        }

                        resource.Catagories.Add(marksCatagoryResource);
                    }

                }));

            CreateMap<Proposal, ProposalResource>()
                .ForMember(x => x.Type, opt => opt.MapFrom(p => p.ProposalTypeId))
                .ForMember(x => x.Reviewer, opt => opt.MapFrom(p => p.Student.Reviewer))
                .ForMember(x => x.Supervisor, opt => opt.MapFrom(p => p.Student.Supervisor));

            CreateMap<Proposal, ProposalWithOutNavResource>()
                .ForMember(x => x.Type, opt => opt.MapFrom(p => p.ProposalTypeId));

            CreateMap<ApplicationUser, UserResource>();
            //  .ForMember(x => , opt => opt.MapFrom(p => p.))

            CreateMap<ApplicationUser, UserWithProposalResource>();

            CreateMap<Course, CourseResource>();


        }
    }
}
