<template>
  <div>
    <div class="container">
      <div class="block" :class="{ animate: animatedBlock }"></div>
      <button @click="animateBlock">Animate</button>
    </div>
    <div class="container">
      <!-- must have one direct children -->
      <transition
        :css="false"
        name="para"
        @before-enter="enterFromEevent"
        @enter="activeEvent"
        @after-enter="afterEnter"
        @before-leave="leaveFromEvent"
        @leave="leaveEvent"
        @after-leave="afterLeaveEvent"
        enter-to-class="some-class"
        enter-active-class="some-class"
      >
        <p v-if="paragraphIsVisible">paragraph here</p>
      </transition>
      <button @click="toogleParagraph">toggle</button>
    </div>
    <div class="container">
      <!-- works because one is removed from the dom -->
      <transition name="fade-button" mode="out-in">
        <button @click="showUsers" v-if="!usersAreVisible">show users</button>
        <button @click="hideUsers" v-else>hide users</button>
      </transition>
    </div>
    <base-modal @close="hideDialog" :open="dialogIsVisible">
      <p>This is a test dialog!</p>
      <button @click="hideDialog">Close it!</button>
    </base-modal>
    <div class="container">
      <button @click="showDialog">Show Dialog</button>
    </div>
  </div>
</template>  

<script>
export default {
  data() {
    return {
      dialogIsVisible: false,
      animatedBlock: false,
      paragraphIsVisible: false,
      usersAreVisible: false,
    };
  },
  methods: {
    enterFromEevent(element) {
      element.style.opacity = 0;
      console.log(element);
    },
    activeEvent(element, done) {
      console.log(element);
      let round = 1;
      const interval = setInterval(() => {
        element.style.opacity = round * 0.01;
        round++;
        if (round > 100) {
          clearInterval(interval);
          done();
        }
      }, 20);
    },
    afterElement(element) {
      console.log(element);
    },
    leaveFromEvent(element) {
      console.log(element);
    },
    leave() {},
    afterLeaveEvent() {},
    showUsers() {
      this.usersAreVisible = true;
    },
    hideUsers() {
      this.usersAreVisible = false;
    },
    showDialog() {
      this.dialogIsVisible = true;
    },
    hideDialog() {
      this.dialogIsVisible = false;
    },
    animateBlock() {
      this.animatedBlock = true;
    },
    toogleParagraph() {
      this.paragraphIsVisible = !this.paragraphIsVisible;
    },
  },
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
button {
  font: inherit;
  padding: 0.5rem 2rem;
  border: 1px solid #810032;
  border-radius: 30px;
  background-color: #810032;
  color: white;
  cursor: pointer;
}
button:hover,
button:active {
  background-color: #a80b48;
  border-color: #a80b48;
}
.block {
  width: 8rem;
  height: 8rem;
  background-color: #290033;
  margin-bottom: 2rem;
  /* transition: transform 0.3s ease-out; */
}
.container {
  max-width: 40rem;
  margin: 2rem auto;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  padding: 2rem;
  border: 2px solid #ccc;
  border-radius: 12px;
}
.animate {
  /* transform: translateX(-80px); */
  animation: slide-fade 0.3s ease-out forwards;
}

.fade-button-enter-from,
.fade-button-leave-to {
  opacity: 0;
}
.fade-button-enter-active {
  transition: opacity 0.3s ease-out;
}

.fade-button-leave-active {
  transition: opacity 0.3s ease-in;
}

.fade-button-enter-to,
.fade-button-leave-from {
  opacity: 1;
}

@keyframes modal {
  0% {
    opacity: 0;
    transform: translateY(-50px) scale(0.9);
  }
  100% {
    opacity: 1;
    transform: translateY(0) scale(1);
  }
}

@keyframes slide-fade {
  0% {
    transform: translateX(0) scale(1);
  }

  70% {
    transform: (-120px) scale(1, 1);
  }

  100% {
    transform: translateX(-150px) scale(1);
  }
}

.v-enter-from {
  /* opacity: 0;
  transform: translateY(-30px); */
}

.v-enter-active {
  /* transition: all 0.3s ease-out; */
  animation: slide-fade 0.3s ease-out;
}

.v-enter-to {
  /* opacity: 1;
  transform: translateY(0); */
}

.v-leave-from {
  /* opacity: 1;
  transform: translateY(0); */
}

.v-leave-active {
  /* transition: all 0.3s ease-in; */
  animation: slide-fade 0.3s ease-out;
}

.v-leave-to {
  /* opacity: 0;
  transform: translateY(30px); */
}

/* /////////////////// */
/**
.para-enter-from {
  /* opacity: 0;
  transform: translateY(-30px); */
/* } */

/* .para-enter-active { */
/* transition: all 0.3s ease-out; */
/* animation: slide-fade 0.3s ease-out;
} */

/* .para-enter-to { */
/* opacity: 1;
  transform: translateY(0); */
/* } */
/* 
.para-leave-from {
  opacity: 1;
  transform: translateY(0);
} */

/* .para-leave-active {
  transition: all 0.3s ease-in;
  animation: slide-fade 0.3s ease-out;
} */

/* .para-leave-to {
  opacity: 0;
  transform: translateY(30px);
} */
</style>