// 文件描述：中台API功能结构体定义
//--------------------------------------------------------------------------------------------------
// 修改日期      版本          作者            备注
//--------------------------------------------------------------------------------------------------
// 2020/4/16 星期三 下午 3:44:26    001.000.001  SHENGHB
//--------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace macli
{
    // 第1结果集内容
    public class FirstSetAns
    {
	    public int RetCode; // 信息代码
	    public string MsgText; // 信息内容
    };
    // 量化登录
    public struct ReqCosLogin
    {
        public string UserCode; // 用户代码
        public string AuthData; // 认证数据
        public string EncryptKey; // 加密因子
    }
    // 用户登录
    public struct ReqAcctLogin
    {
        public string AcctType; // 账户类型
        public string AcctId; // 账户标识
        public string Encryptkey; // 加密因子
        public string AuthData; // 认证数据
        public byte AuthType; // 认证类型
        public byte UseScope; // 使用范围
    }

    public struct RspCosLogin
    {
        public string UserCode;
        public string PhoneNum;
        public string SessionId;
        public byte IsLv2Auth;
        public byte MtkProType;
        public override string ToString()
        {
            return String.Format(@"UserCode:{0},PhoneNum:{1},SessionId:{2},IsLv2Auth:{3},MtkProType:{4}",
                UserCode, PhoneNum, SessionId, ((char)IsLv2Auth).ToString(), ((char)MtkProType).ToString());
        }
    }

    public struct RspUserLogin
    {
        public long CustCode;
        public long CuacctCode;
        public byte StkEx;
        public string StkBd;
        public string TrdAcct;
        public byte TrdAcctStatus;
        public string StkPbu;
        public string AcctType;
        public string AcctId;
        public string TrdAcctName;
        public string SessionId;
        public int IntOrg;
        public override string ToString()
        {
            return String.Format(@"客户代码:{0},资产账户:{1},交易市场:{2},交易板块:{3},证券账户:{4}," +
                "账户状态:{5},交易单元:{6},账户类型:{7},账户标识:{8},账户名称:{9},会话凭证:{10},内部机构:{11}",
                CustCode, CuacctCode, ((char)StkEx).ToString(), StkBd, TrdAcct,
                ((char)TrdAcctStatus).ToString(), StkPbu, AcctType, AcctId, TrdAcctName, SessionId, IntOrg);
        }
    }

    // 10388101:量化委托
    public struct ReqCosOrderField
    {
        public string CuacctCode; // 资产账户
        public byte CuacctType; // 资产账户类型
        public string CustCode; // 客户代码
        public string Trdacct; // 交易账户
        public byte Exchange; // 交易所
        public string Stkbd; // 交易板块
        public int StkBiz; // 交易业务
        public int StkBizAction; // 业务活动
        public string TrdCode; // 品种代码
        public string OptNum; // 合约编码
        public int IntOrg; // 内部机构
        public int OrderBsn; // 委托批号
        public long OrderQty; // 委托数量
        public string OrderPrice; // 委托价格
        public string StopPrice; // 触发价格
        public int ValidDate; // 截止日期
        public int TrdCodeCls; // 品种类型
        public string OrderAttr; // 高级属性256
        public int AttrCode; // 属性代码
        public int BgnExeTime; // 执行开始时间
        public int EndExeTime; // 执行结束时间
        public string SpreadName; //  组合名称64
        public string UndlCode; // 标的代码16
        public int ConExpDate; // 合约到期日
        public string ExercisePrice; // 行权价
        public long ConUnit; // 合约单位
        public string CliOrderNo; // 客户端委托编号32
        public string CliRemark; // 备用信息256
        public string BusinessUnit; // 业务单元21
        public string GtdData; // GTD日期
        public byte ContingentCondition; // 触发条件
        public byte ForceCloseReason; // 强平原因
        public int IsSwapOrder; // 互换单标志
        public string OrderIdEx; // 外部合同序号64
    }

    public struct RspCosOrderField
    {
        public string CliOrderNo; // 客户端委托编号32
        public int OrderBsn; // 委托批号
        public int OrderNo; // 委托编号
        public int OrderDate; // 委托日期
        public string OrderTime; // 委托时间
        public byte ExeStatus; // 执行状态
        public string ExeInfo; // 执行信息128
        public long OrderQty; // 委托数量
        public int TrdBiz; // 交易业务
        public int TrdBizAction; // 业务活动
        public string TrdCode; // 品种代码
        public string UndlCode; // 标的代码16
        public string CuacctCode; // 资产账户

        public override string ToString()
        {
            return String.Format(@"客户端委托编号:{0},委托批号:{1},委托编号:{2},委托日期:{3},委托时间:{4}," +
                "执行状态:{5},执行信息:{6},委托数量:{7},交易业务:{8},业务活动:{9},品种代码:{10},标的代码:{11}，资产账户:{12}",
                CliOrderNo, OrderBsn, OrderNo, OrderDate, OrderTime,
                ((char)ExeStatus).ToString(), ExeInfo, OrderQty, TrdBiz, TrdBizAction, TrdCode, UndlCode, CuacctCode);
        }
    }

    // 10388108:自定义篮子委托
    public struct ReqCosCustomBasketOrderField
    {
        public string CustCode; // 客户代码
        public string CuacctCode; // 资产账户
        public byte CuacctType; // 账户类型
        public string SubsysConnstr; // 子系统连接串
        public int PassNum; // 通道号
        public int StkBiz; // 证券业务
        public int StkBizAction; // 业务行为
        public int OrderBsn; // 委托批号
        public string StrategyText; // 策略信息32768
        public string HdId; // 硬盘ID 32
        public string TrdTermcode; // 终端特征码 20
        public int CuacctSn; // 账户序号
        public byte ErrorFlag; // 错误屏蔽标志 0: 当一条委托出错时，策备委托全部失败，并报错 1: 当一条委托出错时，策备委托继续执行，结果输出每一条委托结果信息
        public byte PublishCtrlFlag; // 股票风控标志
        public string CliRemark; // 留痕信息 256
        public int IntOrg; // 内部机构
        public string CliOrderNo; // 客户端委托编号 32
    }

    public struct RspCosCustomBasketOrderField
    {
        public int OrderBsn; // 委托批号
        public string CuacctCode; // 资产账户
        public byte CuacctType; // 账户类型
        public int OrderDate; // 委托日期
        public string OrderTime; // 委托时间
        public byte ExeStatus; // 执行状态
        public string ExeInfo; // 执行信息
        public int StkBiz; // 证券业务
        public int StkBizAction; // 业务行为

        public override string ToString()
        {
            return String.Format(@"委托批号:{0},资产账户:{1},账户类型:{2},委托日期:{3},委托时间:{4}," +
                "执行状态:{5},执行信息:{6},证券业务:{7},业务活动:{8}",
                OrderBsn, CuacctCode, ((char)CuacctType).ToString(), OrderDate, OrderTime,
                ((char)ExeStatus).ToString(), ExeInfo, StkBiz, StkBizAction);
        }
    }

    //10388102:委托撤单
    public struct ReqCosCancelOrderField
    {
        public string CuacctCode; //资产账户
        public byte CuacctType; //账户类型
        public int IntOrg; //内部机构
        public string Stkbd; //交易板块
        public int OrderDate; //委托日期
        public int OrderNo; //委托编号
        public int OrderBsn; //委托批号
        public int CliRemark; //备用信息 256
    }

    public struct RspCosCancelOrderField
    {
        public string CuacctCode; //资产账户
        public string Stkbd; //交易板块
        public int OrderDate; //委托日期
        public int OrderNo; //委托编号
        public string CliOrderNo; //客户端委托编号 32
        public int OrderBsn; //委托批号
        public byte ExeStatus; //执行状态
        public string ExeInfo; //执行信息128
        public long OrderQty; //委托数量
        public int TrdBiz; //交易业务
        public int TrdBizAction; //业务活动
        public string TrdCode; //品种代码
        public string UndlCode; //标的代码16
        public byte CancelStatus; //内部撤单标志

        public override string ToString()
        {
            return String.Format(@"资产账户:{0},交易板块:{1},委托日期:{2},委托编号:{3},委托批号:{4},客户端委托编号:{5},执行状态:{6}," +
                "执行信息:{7},委托数量:{8},交易业务:{9},业务活动:{10},品种代码:{11},标的代码:{12}，撤单标志:{13}",
                CuacctCode, Stkbd, OrderDate, OrderNo, OrderBsn, CliOrderNo, ((char)ExeStatus).ToString(),
                 ExeInfo, OrderQty, TrdBiz, TrdBizAction, TrdCode, UndlCode, ((char)CancelStatus).ToString());
        }

    }

    //10388301:量化委托查询
    public struct ReqCosOrderInfoField
    {
        public string CuacctCode; //资产账户  CUACCT_CODE BIGINT     Y 8920 
        public byte CuacctType; //资产账户类型
        public string Stkbd; //交易板块  STKBD       CHAR(2)    X 625  
        public int TrdCodeCls; //品种类型  TRD_CODE_CLSINTEGER    X 8970 
        public string TrdCode; //品种代码  TRD_CODE    VARCHAR(8) X 48   
        public string OptNum; //合约编码  OPT_NUM     VARCHAR(16)X 9082 
        public int OrderNo; //委托编号  ORDER_NO    INTEGER    X 9106 
        public int OrderBsn; //委托批号  ORDER_BSN   INTEGER    X 66   
        public string Trdacct; //交易账户  TRDACCT     VARCHAR(10)X 448  
        public int AttrCode; //属性代码  ATTR_CODE   SMALLINT   X 9101 
        public int BgnExeTime; //执行开始时间BGN_EXE_TIMEINTEGER    X 916  
        public byte QueryFlag; //查询方向  QUERY_FLAG  CHAR(1)    Y 90800:向后取数据
        public string QueryPos; //定位串   QUERY_POS   VARCHAR(32)X 8991 与查询方向和资产账户配合使用
        public int QueryNum; //查询行数  QUERY_NUM   INTEGER    Y 8992 最大值为1000
        public byte Flag; //查询标志  FLAG        CHAR(1)    X 9081 ‘1’ :  可撤单
    };

    public struct RspCosOrderInfoField
    {
        public string QryPos; //定位串    QRY_POS       VARCHAR(32) 8991
        public string CuacctCode; //资产账户   CUACCT_CODE   BIGINT      8920
        public string CustCode; //客户代码   CUST_CODE     BIGINT      8902
        public string Trdacct; //交易账户   TRDACCT       VARCHAR(10) 448 
        public byte Exchange; //交易所    EXCHANGE      CHAR(1)     207 
        public string Stkbd; //交易板块   STKBD         CHAR(2)     625 
        public int TrdCodeCls; //品种类型   TRD_CODE_CLS  INTEGER     8970
        public int StkBiz; //交易业务   STK_BIZ       SMALLINT    8842
        public int StkBizAction; //业务活动   STK_BIZ_ACTIONSMALLINT    40  
        public string TrdCode; //品种代码   TRD_CODE      VARCHAR(8)  48  
        public string OptNum; //合约编码   OPT_NUM       VARCHAR(16) 9082
        public int IntOrg; //内部机构   INT_ORG       SMALLINT    8911
        public int OrderDate; //委托日期   ORDER_DATE    INTEGER     8834
        public string OrderTime; //委托时间   ORDER_TIME    VARCHAR(32) 8845
        public int OrderBsn; //委托批号   ORDER_BSN     INTEGER     66  
        public int OrderNo; //委托编号   ORDER_NO      INTEGER     9106
        public long OrderQty; //委托数量   ORDER_QTY     BIGINT      38  
        public string OrderPrice; //委托价格   ORDER_PRICE   CPRICE      44  
        public string StopPrice; //触发价格   STOP_PRICE    CPRICE      8975
        public int ValidDate; //截止日期   VALID_DATE    INTEGER     8859
        public string OrderAttr; //高级属性   ORDER_ATTR    VARCHAR(256)9100
        public int AttrCode; //属性代码   ATTR_CODE     SMALLINT    9101
        public int BgnExeTime; //执行开始时间 BGN_EXE_TIME  INTEGER     916 
        public int EndExeTime; //执行结束时间 END_EXE_TIME  INTEGER     917 
        public string SpreadName; //组合名称   SPREAD_NAME   VARCHAR(64) 8971
        public string UndlCode; //标的代码   UNDL_CODE     VARCHAR(16) 8972
        public int ConExpDate; //合约到期日  CON_EXP_DATE  INTEGER     8976
        public string ExercisePrice; //行权价    EXERCISE_PRICECPRICE      8973
        public long ConUnit; //合约单位   CON_UNIT      BIGINT      8974
        public string CliOrderNo; //客户端委托编号CLI_ORDER_NO  VARCHAR(32) 9102
        public string CliRemark; //备用信息   CLI_REMARK    VARCHAR(32) 8914
        public byte ExeStatus; //执行状态   EXE_STATUS    CHAR(1)     9103
        public string ExeInfo; //执行信息   EXE_INFO      VARCHAR(128)9104
        public long ExeQty; //执行数量   EXE_QTY       BIGINT      9105
        public long MatchedQty; //已成交数量  MATCHED_QTY   BIGINT      387 
        public long WithdrawnQty; //已撤单数量  WITHDRAWN_QTY BIGINT      8837
        public string MatchedAmt; //已成交金额  MATCHED_AMT   CMONEY      8504
        public string UpdateTime; //最后修改时间 UPDATE_TIME   VARCHAR(32) 8757

        public override string ToString()
        {
            return String.Format(@"定位串:{0}, 资金账户:{1}, 客户代码:{2}, 交易账户:{3}, 交易所:{4}, 交易板块:{5}, 品种类型:{6}, " +
                "交易业务:{7}, 业务活动:{8}, 品种代码:{9}, 合约编码:{10}, 内部机构:{11}, 委托日期:{12}, 委托时间:{13}, " +
                "委托批号:{14}, 委托编号:{15}, 委托数量:{16}, 委托价格:{17}, 触发价格:{18}, 截止日期:{19}，高级属性:{20}, " +
                "属性代码:{21}, 执行开始时间:{22}, 执行结束时间:{23}, 组合名称:{24}, 标的代码:{25}, 合约到期日:{26}, 行权价:{27}, " +
                "合约单位:{28}, 客户端委托编号:{29}, 备用信息:{30}, 执行状态:{31}, 执行信息:{32}, 执行数量:{33}, 已成交数量:{34}, " +
                "已撤单数量:{35}, 已成交金额:{36}, 最后修改时间:{37}",
                QryPos, CuacctCode, CustCode, Trdacct, ((char)Exchange).ToString(), Stkbd, TrdCodeCls,
                StkBiz, StkBizAction, TrdCode, OptNum, IntOrg, OrderDate, OrderTime,
                OrderBsn, OrderNo, OrderQty, OrderPrice, StopPrice, ValidDate, OrderAttr, 
                AttrCode, BgnExeTime, EndExeTime, SpreadName, UndlCode, ConExpDate, ExercisePrice, 
                ConUnit, CliOrderNo, CliRemark, ((char)ExeStatus).ToString(), ExeInfo, ExeQty, MatchedQty, 
                WithdrawnQty, MatchedAmt, UpdateTime);
        }

    };

    //量化成交查询
    public struct ReqCosMatchInfoField
    {
        public string CuacctCode; //资产账户CUACCT_CODEBIGINT     Y 8920 
        public byte CuacctType; //资产账户类型
        public string Stkbd; //交易板块STKBD      CHAR(2)    X 625  
        public string TrdCode; //品种代码TRD_CODE   VARCHAR(8) X 48   
        public int OrderNo; //委托编号ORDER_NO   INTEGER    X 9106 
        public int OrderBsn; //委托批号ORDER_BSN  INTEGER    X 66   
        public string Trdacct; //交易账户TRDACCT    VARCHAR(10)X 448  
        public string OptNum; //合约代码OPT_NUM    VARCHAR(16)X 9082 
        public byte QueryFlag; //查询方向QUERY_FLAG CHAR(1)    Y 90800:向后取数据
        public string QueryPos; //定位串 QUERY_POS  VARCHAR(32)X 8991 与查询方向和资产账户配合使用
        public int QueryNum; //查询行数QUERY_NUM  INTEGER    Y 8992 最大值为1000
        public string CliOrderNo; //查询行数QUERY_NUM  INTEGER    Y 8992 最大值为1000
    };

    public struct RspCosMatchInfoField
    {
        public string QryPos; //定位串     QRY_POS           VARCHAR(32)8991
        public int OrderDate; //委托日期    ORDER_DATE        INTEGER    8834
        public byte MatchedType; //成交类型    MATCHED_TYPE      CHAR(1)    8992
        public string MatchedSn; //成交编号    MATCHED_SN        VARCHAR(32)17  
        public int OrderBsn; //委托批号    ORDER_BSN         INTEGER    66  
        public long CliOrderGroupNo; //组合编号    CLI_ORDER_GROUP_NOBIGINT     9301
        public string ClientId; //客户订单标识  CLIENT_ID         VARCHAR(32)8858
        public int OrderNo; //委托编号    ORDER_NO          INTEGER    9106
        public string OrderId; //合同序号    ORDER_ID          VARCHAR(10)11  
        public string CuacctCode; //资产账户    CUACCT_CODE       BIGINT     8920
        public byte CuacctType; //资产账户类型
        public string CustCode; //客户代码    CUST_CODE         BIGINT     8902
        public string Trdacct; //交易账户    TRDACCT           VARCHAR(10)448 
        public byte Exchange; //交易所     EXCHANGE          CHAR(1)    207 
        public string Stkbd; //交易板块    STKBD             CHAR(2)    625 
        public int StkBiz; //交易业务    STK_BIZ           SMALLINT   8842
        public int StkBizAction; //业务活动    STK_BIZ_ACTION    SMALLINT   40  
        public string TrdCode; //品种代码    TRD_CODE          VARCHAR(8) 48  
        public long MatchedQty; //已成交数量   MATCHED_QTY       BIGINT     387 
        public string MatchedPrice; //成交价格    MATCHED_PRICE     CPRICE     8841
        public int MatchedDate; //成交日期    MATCHED_DATE      INTEGER    8839
        public string MatchedTime; //成交时间    MATCHED_TIME      VARCHAR(8) 8840
        public int Subsys; //交易系统类型  SUBSYS            SMALLINT   9080
        public int SubsysSn; //交易系统编码  SUBSYS_SN         SMALLINT   8988
        public int ErrorId; //错误代码    ERROR_ID          SMALLINT   8900
        public string ErrorMsg; //错误信息    ERROR_MSG         VARCHAR(81)8901
        public string BrokerId; //经纪公司代码  BROKER_ID         VARCHAR(11)8890
        public string ParticipantId; //会员代码    PARTICIPANT_ID    VARCHAR(11)8724
        public byte TradingRole; //交易角色    TRADING_ROLE      VARCHAR(1) 8763
        public string CombOffsetFlag; //组合开平标志  COMB_OFFSET_FLAG  VARCHAR(5) 8741
        public string CombHedgeFlag; //组合投机套保标志COMB_HEDGE_FLAG   VARCHAR(5) 8742
        public byte PriceSource; //成交价来源   PRICE_SOURCE      VARCHAR(1) 8765
        public string TraderId; //交易所交易员代码TRADER_ID         VARCHAR(21)8726
        public string ClearingPartId; //结算会员编号  CLEARING_PART_ID  VARCHAR(11)8759
        public int BrokerOrderSeq; //经纪公司报单编号BROKER_ORDER_SEQ  SMALLINT   8746
        public string OptNum; // 合约编码  OPT_NUM VARCHAR(16) 9082
        public byte IsWithdraw; // 撤单标志  IS_WITHDRAW CHAR(1) 8836
        public string MatchedAmt; // 成交金额  MATCHED_AMT CMONEY  8504
        public string OrderFrzAmt; // 委托冻结金额  ORDER_FRZ_AMT CMONEY  8831
        public string TotalMatchedAmt; // 累计成交金额  TOTAL_MATCHED_AMT CPRICE  8755
        public string RltSettAmt; // 实时清算金额  RLT_SETT_AMT  CMONEY  8853
        public long TotalMatchedQty; // 已成交总量  TOTAL_MATCHED_QTY BIGINT  8753
        public long WithdrawnQty; // 已撤单数量  WITHDRAWN_QTY BIGINT  8837
        public byte OrderStatus; // 委托状态  ORDER_STATUS  CHAR(1) 39
        public string CliOrderNo; // 客户端委托编号  CLI_ORDER_NO  VARCHAR(32) 9102
        public string TrdCodeName; // 品种代码名称  TRD_CODE_NAME VARCHAR(32) 55

        public override string ToString()
        {
            return String.Format(@"定位串:{0}, 委托日期:{1}, 成交类型:{2}, 成交编号:{3}, 委托批号:{4}, 组合编号:{5}, 客户订单标识:{6}, " +
                "委托编号:{7}, 合同序号:{8}, 资产账户:{9}, 账户类型:{10}, 客户代码:{11}, 交易账户:{12}, 交易所:{13}, " +
                "交易板块:{14}, 交易业务:{15}, 业务活动:{16}, 品种代码:{17}, 已成交数量:{18}, 成交价格:{19}，成交日期:{20}, " +
                "成交时间:{21}, 交易系统类型:{22}, 交易系统编码:{23}, 错误代码:{24}, 错误信息:{25}, 经纪公司代码:{26}, 会员代码:{27}, " +
                "交易角色:{28}, 组合开平标志:{29}, 组合投机套保标志:{30}, 成交价来源:{31}, 交易所交易员代码:{32}, 结算会员编号:{33}, " +
                "经纪公司报单编号:{34}, 合约编码:{35}, 撤单标志:{36}, 成交金额:{37}, 委托冻结金额:{38}, 累计成交金额:{39}, " +
                "实时清算金额:{40}, 已成交总量:{41}, 已撤单数量:{42}, 委托状态:{43}, 客户端委托编号:{44}, 品种代码名称:{45}",
                QryPos, OrderDate, MatchedType, MatchedSn, OrderBsn, CliOrderGroupNo, ClientId,
                OrderNo, OrderId, CuacctCode, ((char)CuacctType).ToString(), CustCode, Trdacct, ((char)Exchange).ToString(),
                Stkbd, StkBiz, StkBizAction, TrdCode, MatchedQty, MatchedPrice, MatchedDate,
                MatchedTime, Subsys, SubsysSn, ErrorId, ErrorMsg, BrokerId, ParticipantId,
                ((char)TradingRole).ToString(), CombOffsetFlag, CombHedgeFlag, ((char)PriceSource).ToString(), TraderId, ClearingPartId,
                BrokerOrderSeq, OptNum, ((char)IsWithdraw).ToString(), MatchedAmt, OrderFrzAmt, TotalMatchedAmt,
                RltSettAmt, TotalMatchedQty, WithdrawnQty, ((char)OrderStatus).ToString(), CliOrderNo, TrdCodeName);
        }
    };

    //10303001:可用资金查询
    public struct ReqStkQryFundField
    {
        public long CustCode; // 客户代码
        public long CuacctCode; // 资产账户
        public byte Currency; // 货币代码
        public int ValueFlag; // 取值标志
    };

    public struct RspStkQryFundField
    {
        public long CustCode; // 客户代码
        public long CuacctCode; // 资产账户
        public byte Currency; // 货币代码
        public int IntOrg; // 内部机构
        public string MarketValue; // 资产总值
        public string FundValue; // 资金资产
        public string StkValue; // 市值
        public string FundLoan; // 融资总金额
        public string FundLend; // 融券总金额
        public string FundPrebln; // 资金昨日余额
        public string FundBln; // 资金余额
        public string FundAvl; // 资金可用金额
        public string FundFrz; // 资金冻结金额
        public string FundUfz; // 资金解冻金额
        public string FundTrdFrz; // 资金交易冻结金额
        public string FundTrdUfz; // 资金交易解冻金额
        public string FundTrdOtd; // 资金交易在途金额
        public string FundTrdBln; // 资金交易轧差金额
        public byte FundStatus; // 资金状态
        public byte CuacctAttr; // 资产账户属性
        public string FundBorrowBln; // 资金内部拆借金额
        public string HFundAvl; // 港通资金可用
        public string HFundTrdFrz; // 港通资金交易冻结
        public string HFundTrdUfz; // 港通资金交易解冻
        public string HFundTrdOtd; // 港通资金交易在途
        public string HFundTrdBln; // 港通资金交易轧差
        public string CreditFundBln; // 融券卖出金额
        public string CreditFundFrz; // 融券卖出金额冻结
        public string QryPos; // 定位串
        public byte HgtFlag; // 港股通资金通用标志
        public int ExtOrg; // 外部机构
        public string Cashproval; // 现金宝资产

        public override string ToString()
        {
            return String.Format(@"客户代码:{0}, 资产账户:{1}, 货币代码:{2}, 内部机构:{3}, 资产总值:{4}, 资金资产:{5}, 市值:{6}, " +
                "融资总金额:{7}, 融券总金额:{8}, 资金昨日余额:{9}, 资金余额:{10}, 资金可用余额:{11}, 资金冻结金额:{12}, 资金解冻金额:{13}, " +
                "资金交易冻结金额:{14}, 资金交易解冻金额:{15}, 资金交易在途金额:{16}, 资金交易轧差金额:{17}, 资金状态:{18}, 资金账户属性:{19}",
                CustCode, CuacctCode, Currency, IntOrg, MarketValue, FundValue, StkValue,
                FundLoan, FundLend, FundPrebln, FundBln, FundAvl, FundFrz, FundUfz,
                FundTrdFrz, FundTrdUfz, FundTrdOtd, FundTrdBln, FundStatus, CuacctAttr);
        }
    };

    //10303002:可用股份查询
    public struct ReqStkQrySharesField
    {
        public long CustCode; // 客户代码
        public long CuacctCode; // 资产账户
        public string Stkbd; // 交易板块
        public string StkCode; // 证券代码
        public string Stkpbu; // 交易单元
        public byte QueryFlag; // 查询方向
        public string Trdacct; // 交易账户
        public string QueryPos; // 定位串
        public int QueryNum; // 查询行数
        public byte ContractFlag; // 启用合约开关
        public byte BizFlag; // 业务标志
        public int IntOrg; // 内部机构
    };

    public struct RspStkQrySharesField
    {
        public string QryPos; // 定位串
        public int IntOrg; // 内部机构
        public long CustCode; // 客户代码
        public long CuacctCode; // 资产账户
        public string Stkbd; // 交易板块
        public string Stkpbu; // 交易单元
        public string Trdacct; // 交易账户
        public byte Currency; // 货币代码
        public string StkCode; // 证券代码
        public string StkName; // 证券名称
        public byte StkCls; // 证券类别
        public long StkPrebln; // 证券昨日余额
        public long StkBln; // 证券余额
        public long StkAvl; // 证券可用数量
        public long StkFrz; // 证券冻结数量
        public long StkUfz; // 证券解冻数量
        public long StkTrdFrz; // 证券交易冻结数量
        public long StkTrdUfz; // 证券交易解冻数量
        public long StkTrdOtd; // 证券交易在途数量
        public long StkTrdBln; // 证券交易扎差数量
        public string StkPcost; // 证券持仓成本
        public string StkPcostRlt; // 证券持仓成本（实时）
        public string StkPlamt; // 证券盈亏金额
        public string StkPlamtRlt; // 证券盈亏金额（实时）
        public string MktVal; // 市值
        public string CostPrice; // 成本价格
        public string ProIncome; // 参考盈亏
        public byte StkCalMktval; // 市值计算标识
        public long StkQty; // 当前拥股数
        public string CurrentPrice; // 最新价格
        public string ProfitPrice; // 参考成本价
        public long StkDiff; // 可申赎数量
        public long StkTrdUnfrz; // 已申赎数量
        public string Income; // 盈亏
        public long StkRemain; // 余券可用数量
        public long StkSale; // 卖出冻结数量
        public byte IsCollat; // 是否是担保品
        public string CollatRatio; // 担保品折算率
        public string MarketValue; // 市值（账户）
        public long MktQty; // 当前拥股数（账户）
        public string LastPrice; // 最新价格（账户）
        public string ProfitRate; // 盈亏比例
        public string AveragePrice; // 买入均价
        public long StkTrdEtfctn; // ETF申购数量
        public long StkTrdEtfrmn; // ETF赎回数量

        public override string ToString()
        {
            return String.Format(@"客户代码:{0}, 资产账户:{1}, 货币代码:{2}, 内部机构:{3}, 交易板块:{4}, 交易单元:{5}, 交易账户:{6}, " +
                "证券代码:{7}, 证券名称:{8}, 证券类别:{9}, 证券昨日余额:{10}, 证券余额:{11}, 证券可用数量:{12}, 证券冻结数量:{13}, " +
                "证券解冻数量:{14}, 证券交易冻结数量:{15}, 证券交易解冻数量:{16}, 证券交易在途数量:{17}, 证券交易轧差数量:{18}, 证券持仓成本:{19}" +
                "证券持仓成本（实时）:{20}, 证券盈亏金额:{21}, 证券盈亏金额（实时）:{22}, 市值:{23}, 成本价格:{24}, 参考盈亏:{25}" +
                "市值计算标识:{26}, 当前拥股数:{27}, 最新价格:{28}, 参考成本价:{29}, 可申赎数量:{30}, 已申赎数量:{31}" +
                "盈亏:{32}, 余券可用数量:{33}, 卖出冻结数量:{34}",
                CustCode, CuacctCode, Currency, IntOrg, Stkbd, Stkpbu, Trdacct,
                StkCode, StkName, StkCls, StkPrebln, StkBln, StkAvl, StkFrz,
                StkUfz, StkTrdFrz, StkTrdUfz, StkTrdOtd, StkTrdBln, StkPcost,
                StkPcostRlt, StkPlamt, StkPlamtRlt, MktVal, CostPrice, ProIncome,
                StkCalMktval, StkQty, CurrentPrice, ProfitPrice, StkDiff, StkTrdUnfrz,
                Income, StkRemain, StkSale);
        }
    };

    //主题订阅
    public struct ReqSubTopicField
    {
        public string Topic;
        public string Filter;
        public string DataSet;
    }
    public struct RspSubTopicField
    {
        public string Topic;
        public string Filter;
        public string AcceptSn;
        public string Channel;
        public string DataSet;

        public override string ToString()
        {
            return String.Format(@"Topic:{0},Filter:{1},DataSet:{2},Channel:{3},AcceptSn:{4}",
                Topic, Filter, DataSet, Channel, AcceptSn);
        }
    }

    //成交回报响应
    public struct RtnOrderField
    {
        public int TrdCodeCls;         //品种类型    TRD_CODE_CLS    INTEGER    8970
        public string MatchedSn;  //成交编号    MATCHED_SN      VARCHAR(32)17  
        public byte Stkex;             //交易市场    STKEX           CHAR(1)    207 字典[STKEX]
        public string StkCode;     //证券代码    STK_CODE        VARCHAR(8) 48  
        public int OrderNo;            //委托编号    ORDER_NO        INTEGER    9106
        public string OrderId;    //合同序号    ORDER_ID        VARCHAR(10)11  
        public string Trdacct;    //交易账户    TRDACCT         VARCHAR(16)448 
        public long MatchedQty;        //成交数量    MATCHED_QTY     BIGINT     387 撤单成交时数为负数
        public string MatchedPrice;//成交价格    MATCHED_PRICE   CPRICE     8841
        public string OrderFrzAmt; //委托冻结金额  ORDER_FRZ_AMT   CMONEY     8831
        public string RltSettAmt;  //实时清算金额  RLT_SETT_AMT    CMONEY     8853
        public string FundAvl;     //资金可用金额  FUND_AVL        CMONEY     8861
        public long StkAvl;            //证券可用数量  STK_AVL         BIGINT     8869
        public string OpptStkpbu;  //对方席位    OPPT_STKPBU     VARCHAR(8) 9107
        public string OpptTrdacct;//对方交易账号  OPPT_TRDACCT    VARCHAR(10)9108
        public int MatchedDate;        //成交日期    MATCHED_DATE    INTEGER    8839
        public string MatchedTime; //成交时间    MATCHED_TIME    VARCHAR(8) 8840
        public byte IsWithdraw;        //撤单标志    IS_WITHDRAW     CHAR(1)    8836字典[IS_WITHDRAW]
        public string CustCode;          //客户代码    CUST_CODE       BIGINT     8902
        public string CuacctCode;        //资产账户    CUACCT_CODE     BIGINT     8920
        public int OrderBsn;           //委托批号    ORDER_BSN       INTEGER    66  
        public int CuacctSn;           //账户序号    CUACCT_SN       SMALLINT   8928
        public string Stkbd;       //交易板块    STKBD           CHAR(2)    625 字典[STKBD]
        public byte MatchedType;       //成交类型    MATCHED_TYPE    CHAR(1)    9080‘0’:内部撤单成交
        public byte OrderStatus;       //委托状态    ORDER_STATUS    CHAR(1)    39  字典[ORDER_STATUS]
        public int StkBiz;             //证券业务    STK_BIZ         SMALLINT   8842
        public int StkBizAction;       //证券业务行为  STK_BIZ_ACTION  SMALLINT   40  
        public int OrderDate;          //委托日期    ORDER_DATE      INTEGER    8834期权专有字段
        public int OrderSn;            //委托序号    ORDER_SN        INTEGER    8832期权专有字段
        public int IntOrg;             //内部机构    INT_ORG         SMALLINT   8911期权专有字段
        public string Stkpbu;      //交易单元    STKPBU          VARCHAR(8) 8843期权专有字段
        public string SubacctCode; //证券账户子编码 SUBACCT_CODE    VARCHAR(8) 9099期权专有字段
        public string OptTrdacct; //期权合约账户  OPT_TRDACCT     VARCHAR(18)9098期权专有字段
        public string OwnerType;   //订单所有类型  OWNER_TYPE      CHAR(3)    9091期权专有字段
        public string OptCode;    //合约代码    OPT_CODE        VARCHAR(32)9083期权专有字段
        public string OptName;    //合约简称    OPT_NAME        VARCHAR(32)9084期权专有字段
        public byte Currency;          //货币代码    CURRENCY        CHAR(1)    15  期权专有字段
        public byte OptUndlCls;        //标的证券类别  OPT_UNDL_CLS    CHAR(1)    9085期权专有字段
        public string OptUndlCode; //标的证券代码  OPT_UNDL_CODE   VARCHAR(8) 9086期权专有字段
        public string OptUndlName;//标的证券名称  OPT_UNDL_NAME   VARCHAR(16)9087期权专有字段
        public string OrderPrice;  //委托价格    ORDER_PRICE     CPRICE4    44  期权专有字段
        public long OrderQty;          //委托数量    ORDER_QTY       BIGINT     38  期权专有字段
        public string OrderAmt;    //委托金额    ORDER_AMT       CMONEY     8830期权专有字段
        public string MatchedAmt;  //已成交金额   MATCHED_AMT     CMONEY     8504期权专有字段
        public string MarginPreFrz;//预占用保证金  MARGIN_PRE_FRZ  CMONEY     9094期权专有字段（卖开委托时填写预冻结的保证金金额，其他情况填“0”）
        public string MarginFrz;   //占用保证金   MARGIN_FRZ      CMONEY     9095期权专有字段（卖开成交时填写实际冻结的保证金金额，其他情况填“0”）
        public string MarginPreUfz;//预释放保证金  MARGIN_PRE_UFZ  CMONEY     9096期权专有字段（买平委托时填写预解冻的保证金金额，其他情况填“0”）
        public string MarginUfz;   //释放保证金   MARGIN_UFZ      CMONEY     9097期权专有字段（买平成交时填写实际解冻的保证金金额，其他情况填“0”）
        public int ErrorId;            //错误代码    ERROR_ID        SMALLINT   8900错误代码
        public string ErrorMsg;   //错误信息    ERROR_MSG       VARCHAR(81)8901错误信息
        public string BrokerId;   //经纪公司代码  BROKER_ID       VARCHAR(11)8890经纪公司代码
        public string InstrumentId;//合约代码    INSTRUMENT_ID   VARCHAR(31)48  合约代码
        public string OrderRef;   //报单引用    ORDER_REF       VARCHAR(13)8738报单引用
        public string UserId;     //用户代码    USER_ID         VARCHAR(16)9080用户代码
        public string ExchangeId;  //交易所代码   EXCHANGE_ID     VARCHAR(9) 207 交易所代码
        public string OrderSysId; //报单编号    ORDER_SYS_ID    VARCHAR(21)8745报单编号
        public string CombOffsetFlag;//组合开平标志  COMB_OFFSET_FLAGVARCHAR(5) 8741组合开平标志
        public string CombHedgeFlag;//组合投机套保标志COMB_HEDGE_FLAG VARCHAR(5) 8742组合投机套保标志
        public string OrderLocalId;//本地报单编号  ORDER_LOCAL_ID  VARCHAR(13)8722本地报单编号
        public int SequenceNo;         //序号      SEQUENCE_NO     SMALLINT   8832序号
        public string CliOrderNo; //客户端委托编号 CLI_ORDER_NO    VARCHAR(32)9102
        public long VolumeTraded;      //已成交总量   VOLUME_TRADED   BIGINT     8753已成交总量
        public long WithdrawnQty;      //已撤单数量   WITHDRAWN_QTY   BIGINT     8837已撤单数量

        public override string ToString()
        {
            return String.Format(@"品种类型:{0},成交编号:{1},交易市场:{2},证券代码:{3},委托编号:{4},合同序号:{5},交易账户:{6},成交数量:{7},成交价格:{8}," +
                "委托冻结金额:{9},实时清算金额:{10},资金可用金额:{11},证券可用数量:{12},对方席位:{13},对方交易账号:{14},成交日期:{15},成交时间:{16}," +
                "撤单标志:{17},客户代码:{18},资产账户:{19},委托批号:{20},账户序号:{21},交易板块:{22},成交类型:{23},委托状态:{24}," +
                "证券业务:{25},证券业务行为:{26},委托日期:{27},委托序号:{28},内部机构:{29},交易单元:{30},证券账户子编码:{31},期权合约账户:{32}," +
                "订单所有类型:{33},合约代码:{34},合约简称:{35},货币代码:{36},标的证券类别:{37},标的证券代码:{38},标的证券名称:{39},委托价格:{40}," +
                "委托数量:{41},委托金额:{42},已成交金额:{43},预占用保证金:{44},占用保证金:{45},预释放保证金:{46},释放保证金:{47},错误代码:{48}," +
                "错误信息:{49},经纪公司代码:{50},合约代码:{51},报单引用:{52},用户代码:{53},交易所代码:{54},报单编号:{55},组合开平标志:{56}," +
                "组合投机套保标志:{57},本地报单编号:{58},序号:{59},客户端委托编号:{60},已成交总量:{61},已撤单数量:{62}",
                TrdCodeCls, MatchedSn, ((char)Stkex).ToString(), StkCode, OrderNo, OrderId, Trdacct, MatchedQty, MatchedPrice,
                OrderFrzAmt, RltSettAmt, FundAvl, StkAvl, OpptStkpbu, OpptTrdacct, MatchedDate, MatchedTime,
                ((char)IsWithdraw).ToString(), CustCode, CuacctCode, OrderBsn, CuacctSn, Stkbd, ((char)MatchedType).ToString(), ((char)OrderStatus).ToString(),
                StkBiz, StkBizAction, OrderDate, OrderSn, IntOrg, Stkpbu, SubacctCode, OptTrdacct,
                OwnerType, OptCode, OptName, ((char)Currency).ToString(), ((char)OptUndlCls).ToString(), OptUndlCode, OptUndlName, OrderPrice,
                OrderQty, OrderAmt, MatchedAmt, MarginPreFrz, MarginFrz, MarginPreUfz, MarginUfz, ErrorId,
                ErrorMsg, BrokerId, InstrumentId, OrderRef, UserId, ExchangeId, OrderSysId, CombOffsetFlag,
                CombHedgeFlag, OrderLocalId, SequenceNo, CliOrderNo, VolumeTraded, WithdrawnQty);
        }
    }

    //量化委托确认回报
    public struct RtnTsuOrderField
    {
        public int OrderBsn; // 委托批号 
        public string OrderId; // 合同序号 
        public string CuacctCode; // 资产账户 
        public string OrderPrice; // 委托价格 
        public long OrderQty; // 委托数量 
        public string OrderAmt; // 委托金额 
        public string OrderFrzAmt; // 冻结金额 
        public string Stkpbu; // 交易单元 
        public string Stkbd; // 交易板块 
        public string StkCode; // 证券代码 
        public string StkName; // 证券名称 
        public int StkBiz; // 证券业务 
        public int StkBizAction; // 业务行为 
        public int CuacctSn; // 账户序号 
        public int OrderNo; // 委托编号 
        public int OrderDate; // 委托日期 
        public string OrderTime; // 委托时间 
        public string Trdacct; // 交易账户 
        public string OptNum; // 合约编码 
        public string OptCode; // 合约代码 
        public string OptName; // 合约简称 
        public string OptUndlCode; // 标的证券代码 
        public byte ExeStatus; // 执行状态 
        public int FrontId; // 前置编号 
        public long SessionId; // 会话编号 
        public int ErrorId; // 错误代码 
        public string ErrorMsg; // 错误信息 
        public int OrderChange; // 改单标识 
        public string CliOrderNo; // 客户端委托编号 
        public byte CuacctType; // 账户类型 
        public int AttrCode; // 属性代码 
        public string TriggerPrice; // 触发价格 
        public string CustCode; // 客户代码 
        public int OrderGroupNo; // 组合单编号 
        public int SubOrderSn; // 子单编号 
        public int TrdDate; // 交易日期 
        public int MainTrdDate; // 母单交易日 
        public string OrderAttr; // 高级属性 
        public string TrdExInfo; // 交易执行信息 
        public byte UpdownCtrl; // 涨停不卖跌停不买标志 
        public byte Stkex; // 交易市场 
        public byte TrdCodeCls; // 证券代码类型 
        public string StopPrice; // 止损价 
        public string TrackMatchPrice; // 动态触发价 
        public int IntOrg; // 内部机构 
        public string ExeInfo; // 执行信息 
        public byte OnoffFlag; // 启停标志 
        public byte Channel; // 操作渠道 
        public byte StrategyType; // 策略类型 
        public string StrategyName; // 策略名称 
        public string CliRemark; // 留痕信息 
        public string CliDefine1; // 客户自定义1 
        public string CliDefine2; // 客户自定义2 
        public string CliDefine3; // 客户自定义3 
        public string Remark1; // 预留字段1 期权专有字段
        public string Remark2; // 预留字段2 
        public string Remark3; // 预留字段3 
        public string Remark4; // 预留字段4 
        public string Remark5; // 预留字段5 
        public string Remark6; // 预留字段6 复杂订单专有字段
        public string Remark7; // 预留字段7 复杂订单专有字段
        public string Remark8; // 预留字段8 复杂订单专有字段
        public string Remark9; // 预留字段9 复杂订单专有字段
        public string Remarka; // 预留字段A 复杂订单专有字段

        public override string ToString()
        {
            return String.Format(@"委托批号:{0},合同序号:{1},委托编号:{2},委托日期:{3},委托时间:{4},资金账号:{5},委托价格:{6},委托数量:{7},委托金额:{8},冻结金额:{9}," +
                "交易单元:{10},交易板块:{11},证券代码:{12},证券名称:{13},证券业务:{14},业务行为:{15},证券账户:{16},账户序号:{17},合约编码:{18},合约代码:{19}," +
                "合约简称:{20},标的证券代码:{21},执行状态:{22},前置编号:{23},会话编号:{24},错误代码:{25},错误信息:{26},改单标识:{27},客户端委托编号:{28}",
                OrderBsn, OrderId, OrderNo, OrderDate, OrderTime, CuacctCode, OrderPrice, OrderQty, OrderAmt, OrderFrzAmt,
                Stkpbu, Stkbd, StkCode, StkName, StkBiz, StkBizAction, Trdacct, CuacctSn, OptNum, OptCode,
                OptName, OptUndlCode, ((char)ExeStatus).ToString(), FrontId, SessionId, ErrorId, ErrorMsg, OrderChange, CliOrderNo);
        }
    };

    //登录信息
    public struct LoginInfo
    {
        public string UserCode; //用户代码
        public string CuacctCode; //资金账号
        public string CustCode; //客户代码
        public string EnAuthData; //账户登录密码
        public string CuacctType; //操作账户类型
        public int IntOrg; //机构代码
        public string Channel; //渠道
        public string SessionId; //会话凭证
        public string ShAcct; //沪A股东账户
        public string SzAcct; //深A股东账户

        public LoginInfo(string usercode, string cuacctcode, string custcode, string cuaccttype, string enauthdata, int intorg, string channel, string sessionid, string shacct, string szacct)
        {
            UserCode = usercode;
            CuacctCode = cuacctcode;
            CustCode = custcode;
            CuacctType = cuaccttype;
            EnAuthData = enauthdata;
            IntOrg = intorg;
            Channel = channel;
            SessionId = sessionid;
            ShAcct = shacct;
            SzAcct = szacct;
        }
    }
}
