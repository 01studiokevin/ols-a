# 主要表

##用户信息表  user info
    id username gender
    account password tel profile
    lastlogin isactive
    describe
    ##用户信息详情表
        followCount
        subscribeCount
        thumbUpCount
        leaningTimeCount

    ##用户课程表（用户参加的课程）
        id
        userId
        coureId
        alreadyLearned(sectionId)

            ##用户角色中间表  user role
##用户角色表  role

课程表 courseinfo
    #baseinfo
    id
    name
    starttime
    endtime
    describe
    老师关联id
    courseTarget
    courseRequire
        课程详情表 course detail info
        课程评价表 course comment info
            userid courseid commentcontent
课程类型表 course type info

老师表 teacher info
    老师关联课程
    老师关联学校
# 扩展表

学校表  school info
    学校关联的课程
    课程关联学校