<template>

  <div>
    <header class="main-header">

      <!-- Logo -->
      <router-link :to="{name: 'home'}" class="logo">
        <!-- mini logo for sidebar mini 50x50 pixels -->
        <span class="logo-mini"><b>O</b>PS</span>
        <!-- logo for regular state and mobile devices -->
        <span class="logo-lg"><b>Proposal</b>Submission</span>
      </router-link>

      <!-- Header Navbar -->
      <nav class="navbar navbar-static-top" >
        <!-- Sidebar toggle button-->
        <a href="#" class="sidebar-toggle"  @click="toggleClass">
          <span class="sr-only">Toggle navigation</span>
        </a>
        <!-- Navbar Right Menu -->
        <div class="navbar-custom-menu">
          <ul class="nav navbar-nav">
            <!-- Messages: style can be found in dropdown.less-->
            <li class="dropdown messages-menu">
              <!-- Menu toggle button -->
              <!--<a href="#" class="dropdown-toggle" data-toggle="dropdown">
                <i class="fa fa-envelope-o"></i>
                <span class="label label-success">4</span>
              </a>-->
              <ul class="dropdown-menu">
                <li class="header">You have 4 messages</li>
                <li>
                  <!-- inner menu: contains the messages -->
                  <ul class="menu">
                    <li>
                      <!-- start message -->
                      <a href="#">
                        <div class="pull-left">
                          <!-- User Image -->
                          <img src="dist/img/avatar04.png" class="img-circle" alt="User Image">
                        </div>
                        <!-- Message title and timestamp -->
                        <h4>
                          Support Team
                          <small><i class="fa fa-clock-o"></i> 5 mins</small>
                        </h4>
                        <!-- The message -->
                        <p>Why not buy a new awesome theme?</p>
                      </a>
                    </li>
                    <!-- end message -->
                  </ul>
                  <!-- /.menu -->
                </li>
                <li class="footer"><a href="#">See All Messages</a></li>
              </ul>
            </li>
            <!-- /.messages-menu -->
            <!-- Notifications Menu -->
            <li class="dropdown notifications-menu">
              <!-- Menu toggle button -->
              <!--<a href="#" class="dropdown-toggle" data-toggle="dropdown">
                <i class="fa fa-bell-o"></i>
                <span class="label label-warning">10</span>
              </a>-->
              <ul class="dropdown-menu">
                <li class="header">You have 10 notifications</li>
                <li>
                  <!-- Inner Menu: contains the notifications -->
                  <ul class="menu">
                    <li>

                      <a href="#">
                        <i class="fa fa-users text-aqua"></i> 5 new members joined today
                      </a>
                    </li>
                    <!-- end notification -->
                  </ul>
                </li>
                <li class="footer"><a href="#">View all</a></li>
              </ul>
            </li>
            <!-- Tasks Menu -->
            <li class="dropdown tasks-menu">
              <!-- Menu Toggle Button -->
              <!--<a href="#" class="dropdown-toggle" data-toggle="dropdown">
                <i class="fa fa-flag-o"></i>
                <span class="label label-danger">9</span>
              </a>-->
              <ul class="dropdown-menu">
                <!--<li class="header">You have 9 tasks</li>-->
                <li>
                  <!-- Inner menu: contains the tasks -->
                  <ul class="menu">
                    <li>
                      <!-- Task item -->
                      <a href="#">
                        <!-- Task title and progress text -->
                        <h3>
                          Design some buttons
                          <small class="pull-right">20%</small>
                        </h3>
                        <!-- The progress bar -->
                        <div class="progress xs">
                          <!-- Change the css width attribute to simulate progress -->
                          <div class="progress-bar progress-bar-aqua" style="width: 20%" role="progressbar"
                               aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                            <span class="sr-only">20% Complete</span>
                          </div>
                        </div>
                      </a>
                    </li>
                    <!-- end task item -->
                  </ul>
                </li>
                <li class="footer">
                  <!--<a href="#">View all tasks</a>-->
                </li>
              </ul>
            </li>
            <!-- User Account Menu -->
            <li class="dropdown user user-menu" :class="userMenuOpen" @click="userHeaderMenu = !userHeaderMenu" v-click-outside="clickOutSide" >
              <!-- Menu Toggle Button -->
              <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                <!-- The user image in the navbar-->
                <img src="dist/img/avatar04.png" class="user-image" alt="User Image">
                <!-- hidden-xs hides the username on small devices so only the image appears. -->
                <span class="hidden-xs">{{name}}</span>
              </a>
              <ul class="dropdown-menu">
                <!-- The user image in the menu -->
                <li class="user-header">
                  <img src="dist/img/user2-160x160.jpg" class="img-circle" alt="User Image">

                  <p>
                    {{ name }}
                  </p>
                </li>
                <!-- Menu Body -->
                <li class="user-body">
                  <!--<div class="row">
                    <div class="col-xs-4 text-center">
                      <a href="#">Link</a>
                    </div>
                    <div class="col-xs-4 text-center">
                      <a href="#">Link</a>
                    </div>
                    <div class="col-xs-4 text-center">
                      <a href="#">Link</a>
                    </div>
                  </div>-->

                </li>
                <!-- Menu Footer-->
                <li class="user-footer">
                  <div class="pull-left">
                    <a href="#" class="btn btn-default btn-flat" @click="passChange">Password Change</a>
                  </div>
                  <div class="pull-right">
                    <a href="#" class="btn btn-default btn-flat" @click="signOut">Sign out</a>
                  </div>
                </li>
              </ul>
            </li>
            <!-- Control Sidebar Toggle Button -->
            <!--<li>
              <a href="#" data-toggle="control-sidebar"><i class="fa fa-gears"></i></a>
            </li>-->
          </ul>
        </div>
      </nav>
    </header>
    <!-- Left side column. contains the logo and sidebar -->
    <aside class="main-sidebar">

      <!-- sidebar: style can be found in sidebar.less -->
      <section class="sidebar">

        <!-- Sidebar user panel (optional) -->
        <div class="user-panel">
          <div class="pull-left image">
            <img src="dist/img/avatar04.png" class="img-circle" alt="User Image">
          </div>
          <div class="pull-left info">
            <p>{{name}}</p>
            <!-- Status -->
            <a href="#"><i class="fa fa-circle text-success"></i> Online</a>
          </div>
        </div>

        <!-- search form (Optional) -->
        <!--<form action="#" method="get" class="sidebar-form">
          <div class="input-group">
            <input type="text" name="q" class="form-control" placeholder="Search...">
            <span class="input-group-btn">
              <button type="submit" name="search" id="search-btn" class="btn btn-flat">
                <i class="fa fa-search"></i>
              </button>
            </span>
          </div>
        </form>-->
        <!-- /.search form -->
        <!-- Sidebar Menu -->
        <ul class="sidebar-menu" data-widget="tree">
          <li class="header">Main Menu</li>
          <!-- Optionally, you can add icons to the links -->
          <!--<li class="active"><a href="#"><i class="fa fa-link"></i> <span>Link</span></a></li>-->
          <router-link :to="{name: m.route}" active-class="active" tag="li" v-for="m in menuList" ><a><i :class="m.icon"></i> <span>{{ m.displayName}}</span></a></router-link>

          <!--<router-link :to="{name: 'semesters'}" active-class="active" tag="li"><a><i class="fa fa-calendar"></i> <span>Semesters</span></a></router-link>
          <router-link :to="{name: 'proposals'}" active-class="active" tag="li"><a><i class="fa fa-lightbulb-o"></i> <span>Submit Proposal</span></a></router-link>
          <router-link :to="{name: 'manageProposal'}" active-class="active" tag="li"><a><i class="fa fa-clock-o"></i> <span>Manage Proposal</span></a></router-link>
          <router-link :to="{name: 'supervisor'}" active-class="active" tag="li"><a><i class="fa fa-sitemap"></i> <span>Supervised Student</span></a></router-link>-->
          <!--<li><a href="#"><i class="fa fa-circle"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>
  <li><a href="#"><i class="fa fa-link"></i> <span>Another Link</span></a></li>-->
          <!--<li class="treeview">
    <a href="#">
      <i class="fa fa-link"></i> <span>Multilevel</span>
      <span class="pull-right-container">
        <i class="fa fa-angle-left pull-right"></i>
      </span>
    </a>
    <ul class="treeview-menu">
      <li><a href="#">Link in level 2</a></li>
      <li><a href="#">Link in level 2</a></li>
    </ul>
  </li>-->
        </ul>
        <!-- /.sidebar-menu -->
      </section>
      <!-- /.sidebar -->
    </aside>
  </div>
</template>

<script>

  import axios from 'axios'
  import bus from '../HelperComponents/Bus'
  export default {

    data: () => ({

      userHeaderMenu: false,

      menuList: []
        
    }),


    computed: {

      userMenuOpen() {

        return {

          'open': this.userHeaderMenu
        }

      },

      name() {

        return this.$store.getters.name;
      }
    },

    methods: {

      clickOutSide() {

        this.userHeaderMenu = false;
      },

      signOut() {

        this.$store.dispatch('logOut');
      },

      toggleClass() {

        var el = document.getElementById('bodyClass');

        el.classList.toggle('sidebar-collapse')
        el.classList.toggle('sidebar-open')

      },
      passChange() {

        bus.$emit("passchange")

      }
    },

    created() {
      if (this.$store.getters.isAuthenticated) {
        axios.get("/api/account/GetMenu").then(({ data }) => {

          this.menuList = data;
        })
      }
    }

}
</script>

<style>

</style>
