import { createRouter, createWebHashHistory } from "vue-router";
import { BasicLayout, ChannelLayout } from "../layouts";
const defaultTitle = "好学兔--在线学习平台";
const routes = [
	{
		path: "/",
		name: "Home",
		component: BasicLayout,
		meta: { title: "好学兔-精品课程在线学习平台" },
		redirect: "/home",
		children: [
			{
				path: "/home",
				name: "Home",
				meta: {
					title: "好学兔-精品课程在线学习平台",
				},
				component: () => import("../views/busines/Home.vue"),
			},
			{
				path: "/course",
				name: "Course",
				meta: {
					title: "课程",
				},
				component: () => import("../views/busines/Course.vue"),
			},
			{
				path: "/channel",
				name: "Channel",
				component: ChannelLayout,
				meta: { title: "频道 & 好学兔" },
				redirect: "/home",
				children: [
					{
						path: "/channel/3002",
						name: "3002",
						meta: { title: "计算机" },
						component: () => import("../views/channel/3002.vue"),
					},
				],
			},
		],
	},
	{
		path: "/login",
		name: "Login",
		component: () => import("../views/busines/Login.vue"),
	},
];

const router = createRouter({
	history: createWebHashHistory(),
	routes,
});

router.beforeEach((to, from, next) => {
	document.title = to.meta.title ? to.meta.title : defaultTitle;
	next();
});

export default router;
