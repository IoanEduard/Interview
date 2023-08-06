<template>
  <div>
    <h2>My Course Goal</h2>
    <!-- Task 1: Output your main course goal with help of the composition API -->
    <!-- Don't hardcode it into the template, instead hardcode it into the JS code -->
    <!-- <h3 v-if="show">{{ goal }}</h3> -->
    <h3 v-if="courseData.goalVisibility">{{ goal }}</h3>
    <!-- Task 2: Toggle (show/ hide) the goal with help of the button  -->
    <button @click="toggle">Toggle Goal</button>
    <!-- Task 3: Manage data in three ways -->
    <!-- => Separate refs -->
    <!-- => Ref Object -->
    <!-- => Reactive Object -->
    <!-- Task 4: Also solve the assignment with the Options API -->
  </div>
</template>

<script>
// import {ref} from 'vue';
import {reactive} from 'vue';

export default {
  setup() {
    // const courseGoal = ref('finish course');
    // const show = ref(true);
    // const courseData({
    //   goal:'finish the course',
    //   goalVisibility: false
    // });

    const courseData = reactive({
      goal: 'finish the course',
      goalVisibility: false
    });
    
    // toggle() {
      // show.value = !show.value;
      // courseData.value.goalVisibility = !courseData.value.goalVisibility;
      //  courseData.goalVisibility = !courseData.goalVisibility;
    // }

    // return { goal: courseGoal, show, toggle };
    // return { goal: courseData, show, toggle };
    return { goal: courseData, show, toggle };
  }
};
</script>

<style>
html {
  font-family: sans-serif;
}
body {
  margin: 3rem;
  text-align: center;
}
</style>