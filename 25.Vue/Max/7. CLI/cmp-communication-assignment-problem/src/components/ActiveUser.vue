<template>
  <div>
    <section class="centered-section">
      <h2>{{ u.name }}</h2>
      <h3>{{ u.age }}</h3>
    </section>
    <section>
      <user-data @user-data-emitter="handleUserData"></user-data>
    </section>
  </div>
</template>

<script>
export default {
  data() {
    return {
      u: {
        name: "no name",
        age: -1,
      },
    };
  },
  methods: {
    handleUserData(username, age) {
      this.u.name = username;
      this.u.age = age;
    },
  },
};
</script>

<style>
</style>