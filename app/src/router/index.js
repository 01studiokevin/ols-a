import { createRouter, createWebHashHistory } from "vue-router";

//channel page list
import channels from "./channel.router";

const defaultTitle = "好学兔--精品课程在线学习平台";

const routes = [
	{
		path: "/",
		name: "Home",
		component: () => import("../layouts/BasicLayout.vue"),
		meta: { title: defaultTitle },
		redirect: "/home",
		children: [
			{
				path: "/home",
				name: "Home",
				meta: {
					title: defaultTitle,
				},
				component: () => import("@views/busines/Home.vue"),
			},
			{
				path: "/course",
				name: "Course",
				meta: {
					title: "课程",
				},
				component: () => import("@views/busines/Course.vue"),
			},
			{
				path: "/channel",
				name: "Channel",
				component: () => import("../views/channel/index.vue"),
				redirect: "/404",
				meta: { title: "频道 & 好学兔" },
				children: [...channels],
			},
		],
	},
	{
		path: "/login",
		name: "Login",
		component: () => import("@views/busines/Login.vue"),
	},
	// {
	// 	path: "/manage",
	// 	name: "Manage",
	// 	component: Adminlayout,
	// 	meta: { title: adminTitle },
	// 	redirect: "/dashboard",
	// 	children: [
	// 		{
	// 			path: "/dashboard",
	// 			name: "Dashboard",
	// 			meta: {
	// 				title: adminTitle,
	// 			},
	// 			component: () => import("@views/admin/dashboard/dashboard.vue"),
	// 		},
	// 		{
	// 			path: "/Menus",
	// 			name: "Menus",
	// 			meta: {
	// 				title: "菜单管理" + suffixTitle,
	// 			},
	// 			component: () => import("@views/admin/Menu/Index.vue"),
	// 		},
	// 	],
	// },
	{
		path: "/:catchAll(.*)",
		component: () => import("@/views/404.vue"),
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
