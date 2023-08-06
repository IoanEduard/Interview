<template>
  <div>
    <base-dialog
      v-if="inputIsInvalid"
      title="Invalid input"
      @close="confirmError"
    >
      <template #default>
        <p>One input is invalid</p>
        <p>fix that shit before submit</p>
      </template>
      <template #actions>
        <base-button @click="confirmError">K</base-button>
      </template>
    </base-dialog>
    <base-card>
      <form @submit.prevent="submitForm">
        <div class="form-control">
          <label for="title">Title</label>
          <input id="title" type="text" name="title" ref="titleInput" />
        </div>
        <div class="form-control">
          <label for="description">Description</label>
          <textarea
            id="description"
            type="text"
            name="description"
            ref="descriptionInput"
          ></textarea>
        </div>
        <div class="form-control">
          <label for="link">Link</label>
          <textarea id="link" type="url" name="link" ref="linkInput"></textarea>
        </div>
        <div>
          <base-button type="submit">Submit</base-button>
        </div>
      </form>
    </base-card>
  </div>
</template>

<script>
export default {
  inject: ['addResource'],
  data() {
    return {
      inputIsInvalid: false,
    };
  },
  methods: {
    submitForm() {
      const enteredTitle = this.$refs.titleInput.value;
      const enteredDescription = this.$refs.descriptionInput.value;
      const enteredTLink = this.$refs.titleInput.value;

      if (
        enteredTitle.trim() === '' ||
        enteredDescription.trim() === '' ||
        enteredTLink.trim() === ''
      ) {
        this.inputIsInvalid = true;
        return;
      }

      this.addResource(enteredTitle, enteredDescription, enteredTLink);
    },

    confirmError() {
      this.inputIsInvalid = false;
    },
  },
};
</script>


<style scoped>
label {
  font-weight: bold;
  display: block;
  margin-bottom: 0.5rem;
}

input,
textarea {
  display: block;
  width: 100%;
  font: inherit;
  padding: 0.15rem;
  border: 1px solid #ccc;
}

input:focus,
textarea:focus {
  outline: none;
  border-color: #3a0061;
  background-color: #f7ebff;
}

.form-control {
  margin: 1rem 0;
}
</style>