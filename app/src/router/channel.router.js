/**
 * file name :channel.routes.js
 * channel router configration
 * v:1
 *
 * **/
/******************************************************************************/

//递归获取 views 文件夹下的所有.vue文件
//ture :包含子目录
const files = require.context("@views/channel", true, /\.vue$/);
let pages = {};
files.keys().forEach((key) => {
	pages[key.replace(/(\.\/|\.vue)/g, "")] = files(key).default;
});

//生成路由规则
let channels = [];
Object.keys(pages).forEach((item) => {
	channels.push({
		path: `/channel/${item}`,
		name: item,
		component: pages[item],
	});
});

export default channels;
