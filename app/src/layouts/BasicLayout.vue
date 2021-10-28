<template>
  <a-layout>
    <a-layout-header :style="{ position: 'fixed', zIndex: 1, width: '100%' }">
      <a-row>
        <a-col :span="4"
          ><div class="logo">
            <img src="../assets/logo.svg" alt="logo" /></div
        ></a-col>
        <a-col :sapn="12">
          <a-menu v-model:selectedKeys="current" mode="horizontal">
            <a-menu-item key="mail"> 课程 </a-menu-item>
            <a-menu-item key="app">学校</a-menu-item>
            <a-sub-menu>
              <template #title>学校云</template>
              <a-menu-item-group title="Item 1">
                <a-menu-item key="setting:1">Option 1</a-menu-item>
                <a-menu-item key="setting:2">Option 2</a-menu-item>
              </a-menu-item-group>
              <a-menu-item-group title="Item 2">
                <a-menu-item key="setting:3">Option 3</a-menu-item>
                <a-menu-item key="setting:4">Option 4</a-menu-item>
              </a-menu-item-group>
            </a-sub-menu>
            <a-menu-item key="alipay">
              <a
                href="https://antdv.com"
                target="_blank"
                rel="noopener noreferrer"
              >
                慕课堂
              </a>
            </a-menu-item>
          </a-menu>
        </a-col>
        <a-col :sapn="8">
          <a-row justify="end" align="center">
            <a-col :span="12">
              <div class="search">
                <a-input-search
                  v-model:value="value"
                  placeholder="搜索感兴趣的课程"
                  enter-button
                  @search="onSearch"
                />
              </div>
            </a-col>
            <a-col :span="12">
              <a-menu mode="horizontal">
                <a-menu-item> 个人中心 </a-menu-item>
                <a-sub-menu>
                  <template #title
                    ><a-avatar :size="large"></a-avatar
                  ></template>
                  <a-menu-item-group title="正在使用手机号登录">
                    <a-menu-item key="setting:1">我的直播</a-menu-item>
                    <a-menu-item key="setting:2">我的认证证书</a-menu-item>
                    <a-menu-item key="setting:2">我的订单</a-menu-item>
                    <a-menu-item key="setting:2">我的优惠卷</a-menu-item>
                    <a-menu-item key="setting:2">设置</a-menu-item>
                  </a-menu-item-group>
                  <a-menu-item-group>
                    <a-menu-item key="setting:3">退出</a-menu-item>
                  </a-menu-item-group>
                </a-sub-menu>
              </a-menu>
            </a-col>
          </a-row>
        </a-col>
      </a-row>
    </a-layout-header>
    <a-layout-content>
      <div class="content-wrap">
        <router-view></router-view>
      </div>
    </a-layout-content>
    <a-layout-footer>Footer</a-layout-footer>
  </a-layout>
</template>

<script>
export default {
  name: "layout",
  data() {
    return {
      nav: [
        { name: "登录", id: 1 },
        { name: "学校", id: 2 },
        { name: "学校云", id: 3 },
        { name: "慕课堂", id: 4 },
        { name: "下载APP", id: 5 },
      ],
      year: null,
      current: ["mail"],
    };
  },
};
</script>

<style lang="scss" scoped>
.ant-layout-header {
  background: #fff;
}
.content-wrap {
  padding: 84px 50px 0 50px;
}
</style>
