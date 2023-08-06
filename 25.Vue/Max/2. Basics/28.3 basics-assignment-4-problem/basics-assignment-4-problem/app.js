const app = Vue.createApp({
    data() {
        return {
            inputValue: '',
            inputValues: [],
            visible: true,
            bgc: ''
        }
    },
    computed: {
        insertInputValues() {
            this.inputValues.push(this.inputValue);
        }
    },
    methods: {
        toggle() {
            this.visible = !this.visible
        }
    }
});

app.mount("#assignment")