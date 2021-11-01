<template>
	<el-container style="background: #eee">
		<el-header :style="{ position: 'fixed', zIndex: 1, width: '100%', background: '#ffffff' }">
			<div class="header-content">
				<el-row :gutter="16">
					<el-col :span="4">
						<div class="col-content border" style="text-align: center">
							<div class="logo">
								<img src="../assets/logo.svg" alt="logo" />
							</div>
						</div>
					</el-col>
					<el-col :span="11">
						<div class="col-content border">
							<el-menu mode="horizontal">
								<el-menu-item key="mail">
									<router-link to="/channel/3002">课程</router-link>
								</el-menu-item>
								<el-menu-item key="app">学校</el-menu-item>
								<el-menu-item key="app">学校云</el-menu-item>
							</el-menu>
						</div>
					</el-col>
					<el-col :span="9">
						<div class="col-content border">
							<el-row justify="flex-end" align="middle" style="height: 64px">
								<el-col :span="12">
									<div style="postion: relative">
										<el-input v-model="input2" :placeholder="searcherPlaceholder" :prefix-icon="Search" />
									</div>
								</el-col>
								<el-col :span="12">
									<div>
										<el-menu mode="horizontal">
											<el-menu-item index="1">个人中心</el-menu-item>
											<el-sub-menu index="2">
												<template #title>
													<el-avatar size="large" src="https://empty" @error="errorHandler">
														<img src="https://cube.elemecdn.com/e/fd/0fc7d20532fdaf769a25683617711png.png" />
													</el-avatar>
												</template>
												<el-menu-item>
													<div class="loginSatus">{{ loginSatus }}</div>
												</el-menu-item>
												<el-menu-item v-for="item in personNav" :key="item.text" index="item.id">
													{{ item.text }}
												</el-menu-item>
											</el-sub-menu>
										</el-menu>
									</div>
								</el-col>
							</el-row>
						</div>
					</el-col>
				</el-row>
			</div>
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
								<router-link to="/home"><img src="../assets/logo.svg" alt="logo" /></router-link>
								<p>{{ footer.slogan }}</p>
							</div>
						</div>
					</el-col>
					<el-col :span="6">
						<div class="copyright">
							<div class="f-title">
								<p>关于我们</p>
							</div>
							<el-row>
								<el-col v-for="item in footer.abouts" :key="item.text" :span="12">
									<div class="about-item">
										<router-link to="item.action">{{ item.text }}</router-link>
									</div>
								</el-col>
							</el-row>
						</div>
					</el-col>
					<el-col :span="6">
						<div class="copyright">
							<div class="f-title">
								<p>友情链接</p>
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
// import { Search } from "@element-plus/icons";
export default {
	name: "layout",
	// components: {
	// 	Search,
	// },
	data() {
		return {
			nav: [
				{ name: "登录", id: 1 },
				{ name: "学校", id: 2 },
				{ name: "学校云", id: 3 },
				{ name: "慕课堂", id: 4 },
				{ name: "下载APP", id: 5 },
			],
			personNav: [
				{ text: "我的直播", id: 1, action: "liveRoom" },
				{ text: "我的认证证书", id: 2, action: "mycert" },
				{ text: "我的订单", id: 3, action: "myOrder" },
				{ text: "我的优惠卷", id: 4, action: "myCoupons" },
				{ text: "设置", id: 5, action: "personInfoEdit" },
				{ text: "退出", id: 6, action: "login" },
			],
			year: null,
			value: null,
			searcherPlaceholder: "搜索感兴趣的课程",
			loginSatus: "正在使用手机号登录",
			footer: {
				slogan: "让每一个有提升愿望的用户能够学到高质量课程，并获得认证。",
				copyright: [
					{ text: "网上有害信息举报（涉未成年人）：网站 https://www.12377.cn 电话 xxx-xxxxxxxx 邮箱（涉未成年人） haoxuerabbit@xxx.com" },
					{ text: "©2014-2021 haoxuerabbit.org" },
				],
				abouts: [
					{ text: "关于我们", action: "aboutus", type: 1 },
					{ text: "学校云", action: "schoolcloud", type: null },
					{ text: "联系我们", action: "contactus", type: 2 },
					{ text: "常见问题", action: "help", type: 3 },
					{ text: "意见反馈", action: "contactus", type: 4 },
					{ text: "法律条款", action: "contactus", type: 5 },
				],
			},
		};
	},
};
</script>

<style lang="scss" scoped>
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
// .copyright {
// 	border: 1px solid orange;
// }
// .footer {
// 	border: 1px solid red;
// }
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
	// border: 1px solid red;
	height: 64px;
}
</style>
