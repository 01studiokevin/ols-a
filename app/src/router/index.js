import { createRouter, createWebHashHistory } from "vue-router";
import { BasicLayout } from "../layouts";

const routes = [
  {
    path: "/",
    name: "Home",
    component: BasicLayout,
    meta: { title: "主页 & 好学兔" },
    redirect: "/home",
    children: [
      {
        path: "/home",
        name: "Home",
        meta: {
          title: "主页 & 好学兔",
        },
        component: () => import("../views/Home.vue"),
      },
      {
        path: "/course",
        name: "Course",
        component: () => import("../views/Course.vue"),
      },
    ],
  },
  {
    path: "/login",
    name: "Login",
    component: () => import("../views/Login.vue"),
  },
];

const router = createRouter({
  history: createWebHashHistory(),
  routes,
});

export default router;
