<template>
  <ul>
    <li>
      <button
        :class="{ active: modelValue === 'poor' }"
        type="button"
        @click="activate('poor')"
      >
        Poor
      </button>
    </li>
    <li>
      <button
        :class="{ active: modelValue === 'poor' }"
        type="button"
        @click="activate('average')"
      >
        Average
      </button>
    </li>
    <li>
      <button
        :class="{ active: modelValue === 'poor' }"
        type="button"
        @click="activate('great')"
      >
        Great
      </button>
    </li>
  </ul>
</template>

<script>
export default {
  props: ['modelValue'],
  //   equivalent to: :model-value="", @update:modelValue=""
  // v-model is a shorthand
  emits: ['update:modelValue'],
  //   data() {
  //     return {
  //       activeOption: this.modelValue,
  //     };
  //   },
//   computed: {
//     activeOption() {
//         return this.activeOption;
//     },
//   },
  methods: {
    activate(option) {
    //   this.activeOption = option;
      this.$emit('updatE:modelValue', option);
    },
  },
};
</script>

<style>
.active {
  border-color: red;
}
.active button {
  color: red;
}
/* dontcare */
</style>