const app = Vue.createApp({
    data() {
        return {
            // output: '',
            value: 0
        }
    },

    computed: {
        output() {
            console.log(this.value);
            return this.value < 37 ? "Not there yet" :
                this.value === 37 ? 37 : "Too much!";
        }
    },

    watch: {
        value() {
            setTimeout(() => {
                this.value = 0;
            }, 5000);
        }
    },

    methods: {
        // incrementByFive() {
        //     this.value += 5;
        // },
        // incrementByOne() {
        //     this.value++;
        // }

        increment(val) {
            this.value += val;
        }
    }
});

app.mount('#assignment');