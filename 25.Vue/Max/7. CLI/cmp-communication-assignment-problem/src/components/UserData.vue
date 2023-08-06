<template>
  <section>
    <form @submit.prevent="submitData">
      <div>
        <label>Name: </label>
        <input type="text" v-model="username" />
      </div>
      <div>
        <label>Age: </label>
        <input type="text" v-model="age" />
      </div>
      <div>
        <button>Submit</button>
      </div>
    </form>
  </section>
</template>

<script>
export default {
  data() {
    return {
      username: "",
      age: 0,
    };
  },
  methods: {
    submitData() {
      this.$emit("user-data-emitter", this.username, this.age);
    },
  },
};
</script>