<template>
  <ul>
    <li v-for="goal in goals" :key="goal">
      <slot :goal="goal" :another-prop="test"></slot>
    </li>
  </ul>
</template>

<script>
export default {
  data() {
    return {
      goals: ["finish course", "learn vue"],
    };
  },
};
</script> 