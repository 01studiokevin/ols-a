<template>
	<el-container>
		<el-header>
			<el-row :gutter="16" align="middle" class="header-content">
				<el-col :span="4">
					<div class="header-warp"><logo /></div>
				</el-col>
				<el-col :span="12">
					<div class="header-item">
						<div class="header-list list-block" v-for="item in nav" :key="item.name">
							<router-link :to="item.action" v-if="item.action != undefined">
								{{ item.name }}
							</router-link>
							<div class="menu-list" v-else-if="item.name == '课程'">
								{{ item.name }}
								<course-menu :courseList="courseList"></course-menu>
							</div>
							<div class="menu-list" v-else>{{ item.name }}</div>
						</div>
					</div>
				</el-col>
				<el-col :span="8">
					<div class="header-item">
						<div class="header-search list-block">
							<el-input v-model="search.value" :placeholder="search.place">
								<template #prefix>
									<el-icon class="el-input__icon"><search /></el-icon>
								</template>
							</el-input>
						</div>
						<div class="tools" style="display: inline-block; margin-left: 30px">
							<el-link>个人中心</el-link>
						</div>
						<!--						<div class="person" style="display: inline-block">-->
						<!--							<el-avatar size="large" src="https://empty" @error="errorHandler">-->
						<!--								<img src="https://cube.elemecdn.com/e/fd/0fc7d20532fdaf769a25683617711png.png" />-->
						<!--							</el-avatar>-->
						<!--						</div>-->
					</div>
				</el-col>
			</el-row>
		</el-header>
		<el-main>
			<div class="content-wrap">
				<router-view></router-view>
			</div>
		</el-main>
		<el-footer>
			<div class="footer">
				<el-row :gutter="16">
					<el-col :span="12">
						<div class="copyright">
							<div class="f-logo">
								<router-link to="/home">
									<logo />
								</router-link>
								<p style="padding-top: 10px">{{ footer.slogan }}</p>
							</div>
						</div>
					</el-col>
					<el-col :span="6">
						<div class="copyright">
							<div class="f-title">
								<p>{{ footer.abouts.title }}</p>
							</div>
							<el-row>
								<el-col v-for="item in footer.abouts.content" :key="item.text" :span="12">
									<!-- <div class="about-item">
										<router-link :to="item.action">
											{{ item.text }}
										</router-link>
									</div> -->
								</el-col>
							</el-row>
						</div>
					</el-col>
					<el-col :span="6">
						<div class="copyright">
							<div class="f-title">
								<p>{{ footer.links.title }}</p>
							</div>
						</div>
					</el-col>
					<el-col :span="24">
						<div class="copyright" style="text-align: center; padding: 10px 10px 10px 10px">
							<p v-for="item in footer.copyright" :key="item.text">{{ item.text }}</p>
						</div>
					</el-col>
				</el-row>
			</div>
		</el-footer>
	</el-container>
</template>

<script>
import { Search } from "@element-plus/icons";
import { Logo, CourseMenu } from "../components/index";
import axios from "axios";
export default {
	components: {
		Logo,
		Search,
		CourseMenu,
	},
	data() {
		return {
			search: {
				value: "",
				place: "搜索感兴趣的课程",
			},
			nav: [
				{ name: "课程", id: 1, children: [] },
				{ name: "学校", id: 2 },
				{ name: "学校云", id: 3 },
				{ name: "慕课堂", id: 4 },
				{ name: "下载APP", id: 5 },
			],
			personNav: [
				{ text: "我的直播", id: 1 },
				{ text: "我的认证证书", id: 2 },
				{ text: "我的订单", id: 3 },
				{ text: "我的优惠卷", id: 4 },
				{ text: "设置", id: 5 },
				{ text: "退出", id: 6 },
			],
			loginSatus: "正在使用手机号登录",
			footer: {
				slogan: "让每一个有提升愿望的用户能够学到高质量课程，并获得认证。",
				copyright: [
					{
						text: "网上有害信息举报（涉未成年人）：网站 https://www.12377.cn 电话 xxx-xxxxxxxx 邮箱（涉未成年人） haoxuerabbit@xxx.com",
					},
					{ text: "©2014-2021 haoxuerabbit.org" },
				],
				abouts: {
					title: "关于我们",
					content: [
						{ text: "关于我们", action: "aboutus", type: 1 },
						{ text: "学校云", action: "schoolcloud", type: null },
						{ text: "联系我们", action: "contactus", type: 2 },
						{ text: "常见问题", action: "help", type: 3 },
						{ text: "意见反馈", action: "contactus", type: 4 },
						{ text: "法律条款", action: "contactus", type: 5 },
					],
				},
				links: {
					title: "友情链接",
					content: [],
				},
			},
			courseList: null,
		};
	},
	mounted() {
		const _this = this;
		// TODO:get all course
	},
};
</script>

<style lang="scss" scoped>
.el-container {
	background: #eeeeee;
}
.el-header {
	position: fixed;
	z-index: 999;
	width: 100%;
	background: #ffffff;
	box-shadow: 0px 3px 22px 0px rgba(0, 0, 0, 0.02);
	overflow: hidden;
}
.header-content {
	position: relative;
	height: 100%;
	padding: 0 50px 0 50px;
	// border: 1px solid red;
}
.header-content {
	.el-col {
		height: auto;
		// border: 1px solid orange;
		// &:nth-child(1) {
		// 	border: 1px solid green;
		// }
	}
}
.list-block {
	display: inline-block;
	margin-left: 30px;
}
.el-footer {
	background: #fff;
	padding: 30px 70px 30px 70px;
	height: auto;
}
.content-wrap {
	padding: 84px 50px 0 50px;
}
.f-title {
	padding: 0 0 20px 0;
}

.about-item {
	padding: 5px 0 5px 0;
	a {
		text-decoration: none;
		color: #000000;
		&:hover {
			color: orange;
		}
	}
}
.border {
	height: 64px;
}
</style>
