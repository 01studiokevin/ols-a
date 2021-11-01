import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import ElementUi from "element-plus";
import "./styles/main.css";
import "element-plus/dist/index.css";
import "@element-plus/icons";

createApp(App).use(store).use(router).use(ElementUi).mount("#app");
