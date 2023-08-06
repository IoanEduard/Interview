<template>
  <div>
    <the-header></the-header>
    <button @click="setSelectedComponent('active-goals')">Active Goals</button>
    <button @click="setSelectedComponent('manange-goals')">Manage Goals</button>
    <!-- <active-goals v-if="setSelectedComponent === 'active-goals'"></active-goals>
    <manage-goals v-if="setSelectedComponent === 'manange-goals'"></manage-goals> -->

    <!-- doesn't destroy, state is cached -->
    <keep-alive>
      <!-- destroys component when moving away -->
      <component :is="selectedComponent"></component>
    </keep-alive>

    <!-- <badge-list></badge-list>
    <user-info
      :full-name="activeUser.name"
      :info-text="activeUser.description"
      :role="activeUser.role"
    ></user-info>
    <course-goals>
      <template #default="prop">
        <h2>{{ prop.goal }}</h2>
        <h2>{{ prop["another-prop"] }}</h2>
      </template>
    </course-goals> -->
  </div>
</template>

<script>
// import BadgeList from "./components/BadgeList.vue";
// import UserInfo from "./components/UserInfo.vue";
import TheHeader from "./components/TheHeader.vue";
// import CourseGoals from "./components/CourseGoals.vue";
import ActiveGoals from "/components/ActiveGoals.vue";
import ManageGoals from "/components/ManageGoals.vue";

export default {
  components: {
    TheHeader: TheHeader,
    ActiveGoals: ActiveGoals,
    ManageGoals: ManageGoals,
  },
  data() {
    return {
      selectedComponent: "active-goals",
      activeUser: {
        name: "Maximilian Schwarzmüller",
        description: "Site owner and admin",
        role: "admin",
      },
    };
  },
  methods: {
    setSelectedComponent(cmp) {
      this.selectedComponent = cmp;
    },
  },
};
</script>

<style>
html {
  font-family: sans-serif;
}

body {
  margin: 0;
}
</style>