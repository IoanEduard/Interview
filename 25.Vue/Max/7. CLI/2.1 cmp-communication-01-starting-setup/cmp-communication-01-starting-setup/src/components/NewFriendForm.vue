<template>
  <form @submit.prevent="submitData">
    <div>
      <label>Name</label>
      <input type="text" v-model="formData.enteredName" />
    </div>
    <div>
      <label>Phone</label>
      <input type="tel" v-model="formData.enteredPhone" />
    </div>
    <div>
      <label>Email</label>
      <input type="email" v-model="formData.enteredEmail" />
    </div>
    <div>
      <button>Add Contact</button>
    </div>
  </form>
</template>

<script>
export default {
  emits: ["add-contact"],
  data() {
    return {
      formData: {
        enteredName: "",
        enteredPhone: "",
        enteredEmail: "",
      },
    };
  },
  methods: {
    submitData() {
      this.$emit("add-contact", this.formData);
    },
  },
};
</script>