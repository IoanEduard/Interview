const app = Vue.createApp({
    data() {
        return {
            friends: [{
                    id: 1,
                    name: "John Doe",
                    phone: "123-456-7890",
                    email: "john.doe@example.com"
                },
                {
                    id: 2,
                    name: "Jane Smith",
                    phone: "987-654-3210",
                    email: "jane.smith@example.com"
                },
                {
                    id: 3,
                    name: "David Johnson",
                    phone: "555-123-4567",
                    email: "david.johnson@example.com"
                }
            ]
        }
    },
    methods: {

    }
});

app.component('user-contact', {
    template: `
    <li>
        <h2>{{friend.name}}</h2>
        <button @click="toggleDetails(friend.id)">{{detailsAreVisible ? 'Hide' : 'Show'}}</button>
        <ul v-if="detailsAreVisible">
            <li><strong>Phone:</strong> {{friend.phone}}</li>
            <li><strong>Email:</strong> {{friend.email}}</li>
        </ul>
    </li>
    `,
    data() {
        return {
            detailsAreVisible: false,
            friend: {
                id: 1,
                name: "John Doe",
                phone: "123-456-7890",
                email: "john.doe@example.com"
            },
        };
    },
    methods: {
        toggleDetails(id) {
            this.detailsAreVisible = !this.detailsAreVisible;
        }
    }
});

app.mount("#app")