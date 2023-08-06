<template>
  <dialog open>
    <slot></slot>
  </dialog>
</template>

<style scroped>
dialog {
  margin: 0;
  position: fixed;
  top: 20vh;
  left: 30%;
  width: 40%;
  padding: 1rem;
  background-color: white;
  box-shadow: 0 2px, 8px rgb(0, 0, 0, 0, 24);
}
</style>