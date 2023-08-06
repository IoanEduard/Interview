<template>
  <section class="container">
    <!-- works in options api not composition -->
    <h2>{{ user.username }}</h2>
    <h3>{{ user.age }}</h3>
    <button @click="setAge">Change age</button>
  </section>
</template>

<script>
// import { ref } from 'vue';
import { reactive } from 'vue'; // made for objects, difference is we don't have the extra 'value' wrapper object
// import { reactive, isReavtive, isRef, toRefs } from 'vue'; // made for objects, difference is we don't have the extra 'value' wrapper object
// torefs makes properties reactive

export default {
  setup() {
    // this. is executed very early and we don't have access to everything
    // const userName = ref('Max');
    // const age = ref(23);

    // const user = ref({
    //   username: 'max',
    //   age: 23
    // })

    const user = reactive({
      username: 'max',
      age: 23,
    });

    function setNewData() {
      user.age = 32;
    }

    console.log(user);

    // setTimeout(() => {
    //   // userName.value = 'max23',
    //   // age.value = 24
    //   // user.value.username = 'max43', // ref version
    //   // user.value.age = 22
    //   user.username = 'max43', // reactive version
    //   user.age = 22
    // }, 2000);

    // expose data to template
    // variables are not reactive to template  value.name
    // return { userName: user.value.userName, age: user.value.age, user: user };
    return { user: user, setAge: setNewData }; // expose the same as with ref
  },
  // data() {
  //   return {
  //     userName: 'Maximilian',
  //   };
  // },
  // methods: {
  //   setNewAge(){
  //     this.age = 32;
  //   }
  // }
};
</script>

<style>
* {
  box-sizing: border-box;
}

html {
  font-family: sans-serif;
}

body {
  margin: 0;
}

.container {
  margin: 3rem auto;
  max-width: 30rem;
  border-radius: 12px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.26);
  padding: 1rem;
  text-align: center;
}
</style>