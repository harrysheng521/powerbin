// �ļ���������̨API���ܽṹ�嶨��
//--------------------------------------------------------------------------------------------------
// �޸�����      �汾          ����            ��ע
//--------------------------------------------------------------------------------------------------
// 2020/4/16    001.000.001  SHENGHB          ����
// 2020/5/26    001.000.002  SHENGHB          ����˫�ڿͻ���ծ��Ϣ��ѯ
//--------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace macli
{
    // ��1���������
    public class FirstSetAns
    {
	    public int RetCode; // ��Ϣ����
	    public string MsgText; // ��Ϣ����
    };
    // ������¼
    public struct ReqCosLogin
    {
        public string UserCode; // �û�����
        public string AuthData; // ��֤����
        public string EncryptKey; // ��������
        public string ThirdPart; // ���������ܴ�
    }
    // �û���¼
    public struct ReqAcctLogin
    {
        public string AcctType; // �˻�����
        public string AcctId; // �˻���ʶ
        public string Encryptkey; // ��������
        public string AuthData; // ��֤����
        public byte AuthType; // ��֤����
        public byte UseScope; // ʹ�÷�Χ
        public byte EncryptType; // ���ܷ�ʽ
    }

    public struct RspCosLogin
    {
        public string UserCode;
        public string PhoneNum;
        public string SessionId;
        public int MenuValidDays;
        public override string ToString()
        {
            return String.Format(@"UserCode:{0},PhoneNum:{1},SessionId:{2},MenuValidDays:{3}",
                UserCode, PhoneNum, SessionId, MenuValidDays);
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
            return String.Format(@"�ͻ�����:{0},�ʲ��˻�:{1},�����г�:{2},���װ��:{3},֤ȯ�˻�:{4}," +
                "�˻�״̬:{5},���׵�Ԫ:{6},�˻�����:{7},�˻���ʶ:{8},�˻�����:{9},�Ựƾ֤:{10},�ڲ�����:{11}",
                CustCode, CuacctCode, ((char)StkEx).ToString(), StkBd, TrdAcct,
                ((char)TrdAcctStatus).ToString(), StkPbu, AcctType, AcctId, TrdAcctName, SessionId, IntOrg);
        }
    }

    // 10388101:����ί��
    public struct ReqCosOrderField
    {
        public string CuacctCode; // �ʲ��˻�
        public byte CuacctType; // �ʲ��˻�����
        public string CustCode; // �ͻ�����
        public string Trdacct; // �����˻�
        public byte Exchange; // ������
        public string Stkbd; // ���װ��
        public int StkBiz; // ����ҵ��
        public int StkBizAction; // ҵ��
        public string TrdCode; // Ʒ�ִ���
        public string OptNum; // ��Լ����
        public int IntOrg; // �ڲ�����
        public int OrderBsn; // ί������
        public long OrderQty; // ί������
        public string OrderPrice; // ί�м۸�
        public string StopPrice; // �����۸�
        public int ValidDate; // ��ֹ����
        public int TrdCodeCls; // Ʒ������
        public string OrderAttr; // �߼�����256
        public int AttrCode; // ���Դ���
        public int BgnExeTime; // ִ�п�ʼʱ��
        public int EndExeTime; // ִ�н���ʱ��
        public string SpreadName; //  �������64
        public string UndlCode; // ��Ĵ���16
        public int ConExpDate; // ��Լ������
        public string ExercisePrice; // ��Ȩ��
        public long ConUnit; // ��Լ��λ
        public string CliOrderNo; // �ͻ���ί�б��32
        public string CliRemark; // ������Ϣ256
        public string BusinessUnit; // ҵ��Ԫ21
        public string GtdData; // GTD����
        public byte ContingentCondition; // ��������
        public byte ForceCloseReason; // ǿƽԭ��
        public int IsSwapOrder; // ��������־
        public string OrderIdEx; // �ⲿ��ͬ���64
    }

    public struct RspCosOrderField
    {
        public string CliOrderNo; // �ͻ���ί�б��32
        public int OrderBsn; // ί������
        public int OrderNo; // ί�б��
        public int OrderDate; // ί������
        public string OrderTime; // ί��ʱ��
        public byte ExeStatus; // ִ��״̬
        public string ExeInfo; // ִ����Ϣ128
        public long OrderQty; // ί������
        public int TrdBiz; // ����ҵ��
        public int TrdBizAction; // ҵ��
        public string TrdCode; // Ʒ�ִ���
        public string UndlCode; // ��Ĵ���16
        public string CuacctCode; // �ʲ��˻�

        public override string ToString()
        {
            return String.Format(@"�ͻ���ί�б��:{0},ί������:{1},ί�б��:{2},ί������:{3},ί��ʱ��:{4}," +
                "ִ��״̬:{5},ִ����Ϣ:{6},ί������:{7},����ҵ��:{8},ҵ��:{9},Ʒ�ִ���:{10},��Ĵ���:{11}���ʲ��˻�:{12}",
                CliOrderNo, OrderBsn, OrderNo, OrderDate, OrderTime,
                ((char)ExeStatus).ToString(), ExeInfo, OrderQty, TrdBiz, TrdBizAction, TrdCode, UndlCode, CuacctCode);
        }
    }

    // 10388108:�Զ�������ί��
    public struct ReqCosCustomBasketOrderField
    {
        public string CustCode; // �ͻ�����
        public string CuacctCode; // �ʲ��˻�
        public byte CuacctType; // �˻�����
        public string SubsysConnstr; // ��ϵͳ���Ӵ�
        public int PassNum; // ͨ����
        public int StkBiz; // ֤ȯҵ��
        public int StkBizAction; // ҵ����Ϊ
        public int OrderBsn; // ί������
        public string StrategyText; // ������Ϣ32768
        public string HdId; // Ӳ��ID 32
        public string TrdTermcode; // �ն������� 20
        public int CuacctSn; // �˻����
        public byte ErrorFlag; // �������α�־ 0: ��һ��ί�г���ʱ���߱�ί��ȫ��ʧ�ܣ������� 1: ��һ��ί�г���ʱ���߱�ί�м���ִ�У�������ÿһ��ί�н����Ϣ
        public byte PublishCtrlFlag; // ��Ʊ��ر�־
        public string CliRemark; // ������Ϣ 256
        public int IntOrg; // �ڲ�����
        public string CliOrderNo; // �ͻ���ί�б�� 32
    }

    public struct RspCosCustomBasketOrderField
    {
        public int OrderBsn; // ί������
        public string CuacctCode; // �ʲ��˻�
        public byte CuacctType; // �˻�����
        public int OrderDate; // ί������
        public string OrderTime; // ί��ʱ��
        public byte ExeStatus; // ִ��״̬
        public string ExeInfo; // ִ����Ϣ
        public int StkBiz; // ֤ȯҵ��
        public int StkBizAction; // ҵ����Ϊ

        public override string ToString()
        {
            return String.Format(@"ί������:{0},�ʲ��˻�:{1},�˻�����:{2},ί������:{3},ί��ʱ��:{4}," +
                "ִ��״̬:{5},ִ����Ϣ:{6},֤ȯҵ��:{7},ҵ��:{8}",
                OrderBsn, CuacctCode, ((char)CuacctType).ToString(), OrderDate, OrderTime,
                ((char)ExeStatus).ToString(), ExeInfo, StkBiz, StkBizAction);
        }
    }

    //10388102:ί�г���
    public struct ReqCosCancelOrderField
    {
        public string CuacctCode; //�ʲ��˻�
        public byte CuacctType; //�˻�����
        public int IntOrg; //�ڲ�����
        public string Stkbd; //���װ��
        public int OrderDate; //ί������
        public int OrderNo; //ί�б��
        public int OrderBsn; //ί������
        public string CliRemark; //������Ϣ 256
    }

    public struct RspCosCancelOrderField
    {
        public string CuacctCode; //�ʲ��˻�
        public string Stkbd; //���װ��
        public int OrderDate; //ί������
        public int OrderNo; //ί�б��
        public string CliOrderNo; //�ͻ���ί�б�� 32
        public int OrderBsn; //ί������
        public byte ExeStatus; //ִ��״̬
        public string ExeInfo; //ִ����Ϣ128
        public long OrderQty; //ί������
        public int TrdBiz; //����ҵ��
        public int TrdBizAction; //ҵ��
        public string TrdCode; //Ʒ�ִ���
        public string UndlCode; //��Ĵ���16
        public byte CancelStatus; //�ڲ�������־

        public override string ToString()
        {
            return String.Format(@"�ʲ��˻�:{0},���װ��:{1},ί������:{2},ί�б��:{3},ί������:{4},�ͻ���ί�б��:{5},ִ��״̬:{6}," +
                "ִ����Ϣ:{7},ί������:{8},����ҵ��:{9},ҵ��:{10},Ʒ�ִ���:{11},��Ĵ���:{12}��������־:{13}",
                CuacctCode, Stkbd, OrderDate, OrderNo, OrderBsn, CliOrderNo, ((char)ExeStatus).ToString(),
                 ExeInfo, OrderQty, TrdBiz, TrdBizAction, TrdCode, UndlCode, ((char)CancelStatus).ToString());
        }

    }

    //10388301:����ί�в�ѯ
    public struct ReqCosOrderInfoField
    {
        public string CuacctCode; //�ʲ��˻�  CUACCT_CODE BIGINT     Y 8920 
        public byte CuacctType; //�ʲ��˻�����
        public string Stkbd; //���װ��  STKBD       CHAR(2)    X 625  
        public int TrdCodeCls; //Ʒ������  TRD_CODE_CLSINTEGER    X 8970 
        public string TrdCode; //Ʒ�ִ���  TRD_CODE    VARCHAR(8) X 48   
        public string OptNum; //��Լ����  OPT_NUM     VARCHAR(16)X 9082 
        public int OrderNo; //ί�б��  ORDER_NO    INTEGER    X 9106 
        public int OrderBsn; //ί������  ORDER_BSN   INTEGER    X 66   
        public string Trdacct; //�����˻�  TRDACCT     VARCHAR(10)X 448  
        public int AttrCode; //���Դ���  ATTR_CODE   SMALLINT   X 9101 
        public int BgnExeTime; //ִ�п�ʼʱ��BGN_EXE_TIMEINTEGER    X 916  
        public byte QueryFlag; //��ѯ����  QUERY_FLAG  CHAR(1)    Y 90800:���ȡ����
        public string QueryPos; //��λ��   QUERY_POS   VARCHAR(32)X 8991 ���ѯ������ʲ��˻����ʹ��
        public int QueryNum; //��ѯ����  QUERY_NUM   INTEGER    Y 8992 ���ֵΪ1000
        public byte Flag; //��ѯ��־  FLAG        CHAR(1)    X 9081 ��1�� :  �ɳ���
    };

    public struct RspCosOrderInfoField
    {
        public string QryPos; //��λ��    QRY_POS       VARCHAR(32) 8991
        public string CuacctCode; //�ʲ��˻�   CUACCT_CODE   BIGINT      8920
        public string CustCode; //�ͻ�����   CUST_CODE     BIGINT      8902
        public string Trdacct; //�����˻�   TRDACCT       VARCHAR(10) 448 
        public byte Exchange; //������    EXCHANGE      CHAR(1)     207 
        public string Stkbd; //���װ��   STKBD         CHAR(2)     625 
        public int TrdCodeCls; //Ʒ������   TRD_CODE_CLS  INTEGER     8970
        public int StkBiz; //����ҵ��   STK_BIZ       SMALLINT    8842
        public int StkBizAction; //ҵ��   STK_BIZ_ACTIONSMALLINT    40  
        public string TrdCode; //Ʒ�ִ���   TRD_CODE      VARCHAR(8)  48  
        public string OptNum; //��Լ����   OPT_NUM       VARCHAR(16) 9082
        public int IntOrg; //�ڲ�����   INT_ORG       SMALLINT    8911
        public int OrderDate; //ί������   ORDER_DATE    INTEGER     8834
        public string OrderTime; //ί��ʱ��   ORDER_TIME    VARCHAR(32) 8845
        public int OrderBsn; //ί������   ORDER_BSN     INTEGER     66  
        public int OrderNo; //ί�б��   ORDER_NO      INTEGER     9106
        public long OrderQty; //ί������   ORDER_QTY     BIGINT      38  
        public string OrderPrice; //ί�м۸�   ORDER_PRICE   CPRICE      44  
        public string StopPrice; //�����۸�   STOP_PRICE    CPRICE      8975
        public int ValidDate; //��ֹ����   VALID_DATE    INTEGER     8859
        public string OrderAttr; //�߼�����   ORDER_ATTR    VARCHAR(256)9100
        public int AttrCode; //���Դ���   ATTR_CODE     SMALLINT    9101
        public int BgnExeTime; //ִ�п�ʼʱ�� BGN_EXE_TIME  INTEGER     916 
        public int EndExeTime; //ִ�н���ʱ�� END_EXE_TIME  INTEGER     917 
        public string SpreadName; //�������   SPREAD_NAME   VARCHAR(64) 8971
        public string UndlCode; //��Ĵ���   UNDL_CODE     VARCHAR(16) 8972
        public int ConExpDate; //��Լ������  CON_EXP_DATE  INTEGER     8976
        public string ExercisePrice; //��Ȩ��    EXERCISE_PRICECPRICE      8973
        public long ConUnit; //��Լ��λ   CON_UNIT      BIGINT      8974
        public string CliOrderNo; //�ͻ���ί�б��CLI_ORDER_NO  VARCHAR(32) 9102
        public string CliRemark; //������Ϣ   CLI_REMARK    VARCHAR(32) 8914
        public byte ExeStatus; //ִ��״̬   EXE_STATUS    CHAR(1)     9103
        public string ExeInfo; //ִ����Ϣ   EXE_INFO      VARCHAR(128)9104
        public long ExeQty; //ִ������   EXE_QTY       BIGINT      9105
        public long MatchedQty; //�ѳɽ�����  MATCHED_QTY   BIGINT      387 
        public long WithdrawnQty; //�ѳ�������  WITHDRAWN_QTY BIGINT      8837
        public string MatchedAmt; //�ѳɽ����  MATCHED_AMT   CMONEY      8504
        public string UpdateTime; //����޸�ʱ�� UPDATE_TIME   VARCHAR(32) 8757

        public override string ToString()
        {
            return String.Format(@"��λ��:{0}, �ʽ��˻�:{1}, �ͻ�����:{2}, �����˻�:{3}, ������:{4}, ���װ��:{5}, Ʒ������:{6}, " +
                "����ҵ��:{7}, ҵ��:{8}, Ʒ�ִ���:{9}, ��Լ����:{10}, �ڲ�����:{11}, ί������:{12}, ί��ʱ��:{13}, " +
                "ί������:{14}, ί�б��:{15}, ί������:{16}, ί�м۸�:{17}, �����۸�:{18}, ��ֹ����:{19}���߼�����:{20}, " +
                "���Դ���:{21}, ִ�п�ʼʱ��:{22}, ִ�н���ʱ��:{23}, �������:{24}, ��Ĵ���:{25}, ��Լ������:{26}, ��Ȩ��:{27}, " +
                "��Լ��λ:{28}, �ͻ���ί�б��:{29}, ������Ϣ:{30}, ִ��״̬:{31}, ִ����Ϣ:{32}, ִ������:{33}, �ѳɽ�����:{34}, " +
                "�ѳ�������:{35}, �ѳɽ����:{36}, ����޸�ʱ��:{37}",
                QryPos, CuacctCode, CustCode, Trdacct, ((char)Exchange).ToString(), Stkbd, TrdCodeCls,
                StkBiz, StkBizAction, TrdCode, OptNum, IntOrg, OrderDate, OrderTime,
                OrderBsn, OrderNo, OrderQty, OrderPrice, StopPrice, ValidDate, OrderAttr, 
                AttrCode, BgnExeTime, EndExeTime, SpreadName, UndlCode, ConExpDate, ExercisePrice, 
                ConUnit, CliOrderNo, CliRemark, ((char)ExeStatus).ToString(), ExeInfo, ExeQty, MatchedQty, 
                WithdrawnQty, MatchedAmt, UpdateTime);
        }

    };

    //�����ɽ���ѯ
    public struct ReqCosMatchInfoField
    {
        public string CuacctCode; //�ʲ��˻�CUACCT_CODEBIGINT     Y 8920 
        public byte CuacctType; //�ʲ��˻�����
        public string Stkbd; //���װ��STKBD      CHAR(2)    X 625  
        public string TrdCode; //Ʒ�ִ���TRD_CODE   VARCHAR(8) X 48   
        public int OrderNo; //ί�б��ORDER_NO   INTEGER    X 9106 
        public int OrderBsn; //ί������ORDER_BSN  INTEGER    X 66   
        public string Trdacct; //�����˻�TRDACCT    VARCHAR(10)X 448  
        public string OptNum; //��Լ����OPT_NUM    VARCHAR(16)X 9082 
        public byte QueryFlag; //��ѯ����QUERY_FLAG CHAR(1)    Y 90800:���ȡ����
        public string QueryPos; //��λ�� QUERY_POS  VARCHAR(32)X 8991 ���ѯ������ʲ��˻����ʹ��
        public int QueryNum; //��ѯ����QUERY_NUM  INTEGER    Y 8992 ���ֵΪ1000
        public string CliOrderNo; //��ѯ����QUERY_NUM  INTEGER    Y 8992 ���ֵΪ1000
    };

    public struct RspCosMatchInfoField
    {
        public string QryPos; //��λ��     QRY_POS           VARCHAR(32)8991
        public int OrderDate; //ί������    ORDER_DATE        INTEGER    8834
        public byte MatchedType; //�ɽ�����    MATCHED_TYPE      CHAR(1)    8992
        public string MatchedSn; //�ɽ����    MATCHED_SN        VARCHAR(32)17  
        public int OrderBsn; //ί������    ORDER_BSN         INTEGER    66  
        public long CliOrderGroupNo; //��ϱ��    CLI_ORDER_GROUP_NOBIGINT     9301
        public string ClientId; //�ͻ�������ʶ  CLIENT_ID         VARCHAR(32)8858
        public int OrderNo; //ί�б��    ORDER_NO          INTEGER    9106
        public string OrderId; //��ͬ���    ORDER_ID          VARCHAR(10)11  
        public string CuacctCode; //�ʲ��˻�    CUACCT_CODE       BIGINT     8920
        public byte CuacctType; //�ʲ��˻�����
        public string CustCode; //�ͻ�����    CUST_CODE         BIGINT     8902
        public string Trdacct; //�����˻�    TRDACCT           VARCHAR(10)448 
        public byte Exchange; //������     EXCHANGE          CHAR(1)    207 
        public string Stkbd; //���װ��    STKBD             CHAR(2)    625 
        public int StkBiz; //����ҵ��    STK_BIZ           SMALLINT   8842
        public int StkBizAction; //ҵ��    STK_BIZ_ACTION    SMALLINT   40  
        public string TrdCode; //Ʒ�ִ���    TRD_CODE          VARCHAR(8) 48  
        public long MatchedQty; //�ѳɽ�����   MATCHED_QTY       BIGINT     387 
        public string MatchedPrice; //�ɽ��۸�    MATCHED_PRICE     CPRICE     8841
        public int MatchedDate; //�ɽ�����    MATCHED_DATE      INTEGER    8839
        public string MatchedTime; //�ɽ�ʱ��    MATCHED_TIME      VARCHAR(8) 8840
        public int Subsys; //����ϵͳ����  SUBSYS            SMALLINT   9080
        public int SubsysSn; //����ϵͳ����  SUBSYS_SN         SMALLINT   8988
        public int ErrorId; //�������    ERROR_ID          SMALLINT   8900
        public string ErrorMsg; //������Ϣ    ERROR_MSG         VARCHAR(81)8901
        public string BrokerId; //���͹�˾����  BROKER_ID         VARCHAR(11)8890
        public string ParticipantId; //��Ա����    PARTICIPANT_ID    VARCHAR(11)8724
        public byte TradingRole; //���׽�ɫ    TRADING_ROLE      VARCHAR(1) 8763
        public string CombOffsetFlag; //��Ͽ�ƽ��־  COMB_OFFSET_FLAG  VARCHAR(5) 8741
        public string CombHedgeFlag; //���Ͷ���ױ���־COMB_HEDGE_FLAG   VARCHAR(5) 8742
        public byte PriceSource; //�ɽ�����Դ   PRICE_SOURCE      VARCHAR(1) 8765
        public string TraderId; //����������Ա����TRADER_ID         VARCHAR(21)8726
        public string ClearingPartId; //�����Ա���  CLEARING_PART_ID  VARCHAR(11)8759
        public int BrokerOrderSeq; //���͹�˾�������BROKER_ORDER_SEQ  SMALLINT   8746
        public string OptNum; // ��Լ����  OPT_NUM VARCHAR(16) 9082
        public byte IsWithdraw; // ������־  IS_WITHDRAW CHAR(1) 8836
        public string MatchedAmt; // �ɽ����  MATCHED_AMT CMONEY  8504
        public string OrderFrzAmt; // ί�ж�����  ORDER_FRZ_AMT CMONEY  8831
        public string TotalMatchedAmt; // �ۼƳɽ����  TOTAL_MATCHED_AMT CPRICE  8755
        public string RltSettAmt; // ʵʱ������  RLT_SETT_AMT  CMONEY  8853
        public long TotalMatchedQty; // �ѳɽ�����  TOTAL_MATCHED_QTY BIGINT  8753
        public long WithdrawnQty; // �ѳ�������  WITHDRAWN_QTY BIGINT  8837
        public byte OrderStatus; // ί��״̬  ORDER_STATUS  CHAR(1) 39
        public string CliOrderNo; // �ͻ���ί�б��  CLI_ORDER_NO  VARCHAR(32) 9102
        public string TrdCodeName; // Ʒ�ִ�������  TRD_CODE_NAME VARCHAR(32) 55

        public override string ToString()
        {
            return String.Format(@"��λ��:{0}, ί������:{1}, �ɽ�����:{2}, �ɽ����:{3}, ί������:{4}, ��ϱ��:{5}, �ͻ�������ʶ:{6}, " +
                "ί�б��:{7}, ��ͬ���:{8}, �ʲ��˻�:{9}, �˻�����:{10}, �ͻ�����:{11}, �����˻�:{12}, ������:{13}, " +
                "���װ��:{14}, ����ҵ��:{15}, ҵ��:{16}, Ʒ�ִ���:{17}, �ѳɽ�����:{18}, �ɽ��۸�:{19}���ɽ�����:{20}, " +
                "�ɽ�ʱ��:{21}, ����ϵͳ����:{22}, ����ϵͳ����:{23}, �������:{24}, ������Ϣ:{25}, ���͹�˾����:{26}, ��Ա����:{27}, " +
                "���׽�ɫ:{28}, ��Ͽ�ƽ��־:{29}, ���Ͷ���ױ���־:{30}, �ɽ�����Դ:{31}, ����������Ա����:{32}, �����Ա���:{33}, " +
                "���͹�˾�������:{34}, ��Լ����:{35}, ������־:{36}, �ɽ����:{37}, ί�ж�����:{38}, �ۼƳɽ����:{39}, " +
                "ʵʱ������:{40}, �ѳɽ�����:{41}, �ѳ�������:{42}, ί��״̬:{43}, �ͻ���ί�б��:{44}, Ʒ�ִ�������:{45}",
                QryPos, OrderDate, ((char)MatchedType).ToString(), MatchedSn, OrderBsn, CliOrderGroupNo, ClientId,
                OrderNo, OrderId, CuacctCode, ((char)CuacctType).ToString(), CustCode, Trdacct, ((char)Exchange).ToString(),
                Stkbd, StkBiz, StkBizAction, TrdCode, MatchedQty, MatchedPrice, MatchedDate,
                MatchedTime, Subsys, SubsysSn, ErrorId, ErrorMsg, BrokerId, ParticipantId,
                ((char)TradingRole).ToString(), CombOffsetFlag, CombHedgeFlag, ((char)PriceSource).ToString(), TraderId, ClearingPartId,
                BrokerOrderSeq, OptNum, ((char)IsWithdraw).ToString(), MatchedAmt, OrderFrzAmt, TotalMatchedAmt,
                RltSettAmt, TotalMatchedQty, WithdrawnQty, ((char)OrderStatus).ToString(), CliOrderNo, TrdCodeName);
        }
    };

    //10303001:�����ʽ��ѯ
    public struct ReqStkQryFundField
    {
        public long CustCode; // �ͻ�����
        public long CuacctCode; // �ʲ��˻�
        public byte Currency; // ���Ҵ���
        public int ValueFlag; // ȡֵ��־
    };

    public struct RspStkQryFundField
    {
        public long CustCode; // �ͻ�����
        public long CuacctCode; // �ʲ��˻�
        public byte Currency; // ���Ҵ���
        public int IntOrg; // �ڲ�����
        public string MarketValue; // �ʲ���ֵ
        public string FundValue; // �ʽ��ʲ�
        public string StkValue; // ��ֵ
        public string FundLoan; // �����ܽ��
        public string FundLend; // ��ȯ�ܽ��
        public string FundPrebln; // �ʽ��������
        public string FundBln; // �ʽ����
        public string FundAvl; // �ʽ���ý��
        public string FundFrz; // �ʽ𶳽���
        public string FundUfz; // �ʽ�ⶳ���
        public string FundTrdFrz; // �ʽ��׶�����
        public string FundTrdUfz; // �ʽ��׽ⶳ���
        public string FundTrdOtd; // �ʽ�����;���
        public string FundTrdBln; // �ʽ���������
        public byte FundStatus; // �ʽ�״̬
        public byte CuacctAttr; // �ʲ��˻�����
        public string FundBorrowBln; // �ʽ��ڲ������
        public string HFundAvl; // ��ͨ�ʽ����
        public string HFundTrdFrz; // ��ͨ�ʽ��׶���
        public string HFundTrdUfz; // ��ͨ�ʽ��׽ⶳ
        public string HFundTrdOtd; // ��ͨ�ʽ�����;
        public string HFundTrdBln; // ��ͨ�ʽ�������
        public string CreditFundBln; // ��ȯ�������
        public string CreditFundFrz; // ��ȯ��������
        public string QryPos; // ��λ��
        public byte HgtFlag; // �۹�ͨ�ʽ�ͨ�ñ�־
        public int ExtOrg; // �ⲿ����
        public string Cashproval; // �ֽ��ʲ�

        public override string ToString()
        {
            return String.Format(@"�ͻ�����:{0}, �ʲ��˻�:{1}, ���Ҵ���:{2}, �ڲ�����:{3}, �ʲ���ֵ:{4}, �ʽ��ʲ�:{5}, ��ֵ:{6}, " +
                "�����ܽ��:{7}, ��ȯ�ܽ��:{8}, �ʽ��������:{9}, �ʽ����:{10}, �ʽ�������:{11}, �ʽ𶳽���:{12}, �ʽ�ⶳ���:{13}, " +
                "�ʽ��׶�����:{14}, �ʽ��׽ⶳ���:{15}, �ʽ�����;���:{16}, �ʽ���������:{17}, �ʽ�״̬:{18}, �ʽ��˻�����:{19}",
                CustCode, CuacctCode, ((char)Currency).ToString(), IntOrg, MarketValue, FundValue, StkValue,
                FundLoan, FundLend, FundPrebln, FundBln, FundAvl, FundFrz, FundUfz,
                FundTrdFrz, FundTrdUfz, FundTrdOtd, FundTrdBln, ((char)FundStatus).ToString(), ((char)CuacctAttr).ToString());
        }
    };

    //10303002:���ùɷݲ�ѯ
    public struct ReqStkQrySharesField
    {
        public long CustCode; // �ͻ�����
        public long CuacctCode; // �ʲ��˻�
        public string Stkbd; // ���װ��
        public string StkCode; // ֤ȯ����
        public string Stkpbu; // ���׵�Ԫ
        public byte QueryFlag; // ��ѯ����
        public string Trdacct; // �����˻�
        public string QueryPos; // ��λ��
        public int QueryNum; // ��ѯ����
        public byte ContractFlag; // ���ú�Լ����
        public byte BizFlag; // ҵ���־
        public int IntOrg; // �ڲ�����
    };

    public struct RspStkQrySharesField
    {
        public string QryPos; // ��λ��
        public int IntOrg; // �ڲ�����
        public long CustCode; // �ͻ�����
        public long CuacctCode; // �ʲ��˻�
        public string Stkbd; // ���װ��
        public string Stkpbu; // ���׵�Ԫ
        public string Trdacct; // �����˻�
        public byte Currency; // ���Ҵ���
        public string StkCode; // ֤ȯ����
        public string StkName; // ֤ȯ����
        public byte StkCls; // ֤ȯ���
        public long StkPrebln; // ֤ȯ�������
        public long StkBln; // ֤ȯ���
        public long StkAvl; // ֤ȯ��������
        public long StkFrz; // ֤ȯ��������
        public long StkUfz; // ֤ȯ�ⶳ����
        public long StkTrdFrz; // ֤ȯ���׶�������
        public long StkTrdUfz; // ֤ȯ���׽ⶳ����
        public long StkTrdOtd; // ֤ȯ������;����
        public long StkTrdBln; // ֤ȯ������������
        public string StkPcost; // ֤ȯ�ֲֳɱ�
        public string StkPcostRlt; // ֤ȯ�ֲֳɱ���ʵʱ��
        public string StkPlamt; // ֤ȯӯ�����
        public string StkPlamtRlt; // ֤ȯӯ����ʵʱ��
        public string MktVal; // ��ֵ
        public string CostPrice; // �ɱ��۸�
        public string ProIncome; // �ο�ӯ��
        public byte StkCalMktval; // ��ֵ�����ʶ
        public long StkQty; // ��ǰӵ����
        public string CurrentPrice; // ���¼۸�
        public string ProfitPrice; // �ο��ɱ���
        public long StkDiff; // ����������
        public long StkTrdUnfrz; // ����������
        public string Income; // ӯ��
        public long StkRemain; // ��ȯ��������
        public long StkSale; // ������������
        public byte IsCollat; // �Ƿ��ǵ���Ʒ
        public string CollatRatio; // ����Ʒ������
        public string MarketValue; // ��ֵ���˻���
        public long MktQty; // ��ǰӵ�������˻���
        public string LastPrice; // ���¼۸��˻���
        public string ProfitRate; // ӯ������
        public string AveragePrice; // �������
        public long StkTrdEtfctn; // ETF�깺����
        public long StkTrdEtfrmn; // ETF�������

        public override string ToString()
        {
            return String.Format(@"�ͻ�����:{0}, �ʲ��˻�:{1}, ���Ҵ���:{2}, �ڲ�����:{3}, ���װ��:{4}, ���׵�Ԫ:{5}, �����˻�:{6}, " +
                "֤ȯ����:{7}, ֤ȯ����:{8}, ֤ȯ���:{9}, ֤ȯ�������:{10}, ֤ȯ���:{11}, ֤ȯ��������:{12}, ֤ȯ��������:{13}, " +
                "֤ȯ�ⶳ����:{14}, ֤ȯ���׶�������:{15}, ֤ȯ���׽ⶳ����:{16}, ֤ȯ������;����:{17}, ֤ȯ������������:{18}, ֤ȯ�ֲֳɱ�:{19}, " +
                "֤ȯ�ֲֳɱ���ʵʱ��:{20}, ֤ȯӯ�����:{21}, ֤ȯӯ����ʵʱ��:{22}, ��ֵ:{23}, �ɱ��۸�:{24}, �ο�ӯ��:{25}, " +
                "��ֵ�����ʶ:{26}, ��ǰӵ����:{27}, ���¼۸�:{28}, �ο��ɱ���:{29}, ����������:{30}, ����������:{31}, " +
                "ӯ��:{32}, ��ȯ��������:{33}, ������������:{34}",
                CustCode, CuacctCode, ((char)Currency).ToString(), IntOrg, Stkbd, Stkpbu, Trdacct,
                StkCode, StkName, ((char)StkCls).ToString(), StkPrebln, StkBln, StkAvl, StkFrz,
                StkUfz, StkTrdFrz, StkTrdUfz, StkTrdOtd, StkTrdBln, StkPcost,
                StkPcostRlt, StkPlamt, StkPlamtRlt, MktVal, CostPrice, ProIncome,
                ((char)StkCalMktval).ToString(), StkQty, CurrentPrice, ProfitPrice, StkDiff, StkTrdUnfrz,
                Income, StkRemain, StkSale);
        }
    };

    //���ⶩ��
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
    //-------------------------------ί��ȷ�ϻر�-----------------------------------------------------
    public struct RtnStkOrderConfirmField
    {
        public byte Stkex;                    // �����г�
        public string StkCode;           // ֤ȯ����
        public string OrderId;          // ��ͬ���
        public string Trdacct;          // �����˻�
        public byte IsWithdraw;               // ������־
        public long CustCode;                 // �ͻ�����
        public long CuacctCode;               // �ʲ��˻�
        public int OrderBsn;                  // ί������
        public int CuacctSn;                  // �˻����
        public string Stkbd;             // ���װ��
        public byte OrderStatus;              // ί��״̬
        public int StkBiz;                    // ֤ȯҵ��
        public int StkBizAction;              // ҵ����Ϊ
        public byte CuacctAttr;               // �˻�����
        public int OrderDate;                 // ί������
        public int OrderSn;                   // ί�����
        public int IntOrg;                    // �ڲ�����
        public string Stkpbu;            // ���׵�Ԫ
        public string OrderPrice;       // ί�м۸�
        public long OrderQty;                 // ί������
        public string SubacctCode;       // ֤ȯ�˻��ӱ���
        public string OptTrdacct;       // ��Ȩ��Լ�˻�
        public string OptCode;          // ��Լ����
        public string OptName;          // ��Լ���
        public byte Currency;                 // ���Ҵ���
        public byte OptUndlCls;               // ���֤ȯ���
        public string OptUndlCode;       // ���֤ȯ����
        public string OptUndlName;      // ���֤ȯ����
        public string CombNum;          // ��ϱ���       ������ϡ�������ʱ��д������������
        public string CombStraCode;     // ��ϲ��Դ���    ������ϡ�������ʱ��д������������
        public string Leg1Num;          // �ɷ�һ��Լ����  ������ϡ������ϡ���Ȩָ��ϲ��걨ʱ��д������������
        public string Leg2Num;          // �ɷֶ���Լ����  ������ϡ������ϡ���Ȩָ��ϲ��걨ʱ��д������������
        public string Leg3Num;          // �ɷ�����Լ����  ������ϡ�������ʱ��д������������
        public string Leg4Num;          // �ɷ��ĺ�Լ����  ������ϡ�������ʱ��д������������
        public string Remark1;          // Ԥ���ֶ�1
        public string Remark2;          // Ԥ���ֶ�2
        public string Remark3;          // Ԥ���ֶ�3
        public string Remark4;          // Ԥ���ֶ�4
        public string Remark5;          // Ԥ���ֶ�5
        public string Remark6;          // Ԥ���ֶ�6
        public string Remark7;          // Ԥ���ֶ�7
        public string Remark8;          // Ԥ���ֶ�8
        public string Remark9;          // Ԥ���ֶ�9
        public string RemarkA;          // Ԥ���ֶ�A

        public override string ToString()
        {
            return String.Format(@"�����г�:{0},֤ȯ����:{1},��ͬ���:{2},�����˻�:{3},������־:{4},�ͻ�����:{5},�ʲ��˻�:{6},ί������:{7},�˻����:{8}," +
                "���װ��:{9},ί��״̬:{10},֤ȯҵ��:{11},ҵ����Ϊ:{12},�˻�����:{13},ί������:{14},ί�����:{15},�ڲ�����:{16},���׵�Ԫ:{17},ί�м۸�:{18}," +
                "ί������:{19},֤ȯ�˻��ӱ���:{20},��Ȩ��Լ�˻�:{21},��Լ����:{22},��Լ���:{23},���Ҵ���:{24},���֤ȯ���:{25},���֤ȯ����:{26},���֤ȯ����:{27}",
                ((char)Stkex).ToString(), StkCode, OrderId, Trdacct, ((char)IsWithdraw).ToString(), CustCode, CuacctCode, OrderBsn, CuacctSn,
                Stkbd, OrderStatus, StkBiz, StkBizAction, ((char)CuacctAttr).ToString(), OrderDate, OrderSn, IntOrg, Stkpbu, OrderPrice,
                OrderQty, SubacctCode, OptTrdacct, OptCode, OptName, ((char)Currency).ToString(), ((char)OptUndlCls).ToString(), OptUndlCode, OptUndlName);
        }
    }

    //�ɽ��ر���Ӧ
    public struct RtnOrderField
    {
        public int TrdCodeCls;         //Ʒ������    TRD_CODE_CLS    INTEGER    8970
        public string MatchedSn;  //�ɽ����    MATCHED_SN      VARCHAR(32)17  
        public byte Stkex;             //�����г�    STKEX           CHAR(1)    207 �ֵ�[STKEX]
        public string StkCode;     //֤ȯ����    STK_CODE        VARCHAR(8) 48  
        public int OrderNo;            //ί�б��    ORDER_NO        INTEGER    9106
        public string OrderId;    //��ͬ���    ORDER_ID        VARCHAR(10)11  
        public string Trdacct;    //�����˻�    TRDACCT         VARCHAR(16)448 
        public long MatchedQty;        //�ɽ�����    MATCHED_QTY     BIGINT     387 �����ɽ�ʱ��Ϊ����
        public string MatchedPrice;//�ɽ��۸�    MATCHED_PRICE   CPRICE     8841
        public string OrderFrzAmt; //ί�ж�����  ORDER_FRZ_AMT   CMONEY     8831
        public string RltSettAmt;  //ʵʱ������  RLT_SETT_AMT    CMONEY     8853
        public string FundAvl;     //�ʽ���ý��  FUND_AVL        CMONEY     8861
        public long StkAvl;            //֤ȯ��������  STK_AVL         BIGINT     8869
        public string OpptStkpbu;  //�Է�ϯλ    OPPT_STKPBU     VARCHAR(8) 9107
        public string OpptTrdacct;//�Է������˺�  OPPT_TRDACCT    VARCHAR(10)9108
        public int MatchedDate;        //�ɽ�����    MATCHED_DATE    INTEGER    8839
        public string MatchedTime; //�ɽ�ʱ��    MATCHED_TIME    VARCHAR(8) 8840
        public byte IsWithdraw;        //������־    IS_WITHDRAW     CHAR(1)    8836�ֵ�[IS_WITHDRAW]
        public string CustCode;          //�ͻ�����    CUST_CODE       BIGINT     8902
        public string CuacctCode;        //�ʲ��˻�    CUACCT_CODE     BIGINT     8920
        public int OrderBsn;           //ί������    ORDER_BSN       INTEGER    66  
        public int CuacctSn;           //�˻����    CUACCT_SN       SMALLINT   8928
        public string Stkbd;       //���װ��    STKBD           CHAR(2)    625 �ֵ�[STKBD]
        public byte MatchedType;       //�ɽ�����    MATCHED_TYPE    CHAR(1)    9080��0��:�ڲ������ɽ�
        public byte OrderStatus;       //ί��״̬    ORDER_STATUS    CHAR(1)    39  �ֵ�[ORDER_STATUS]
        public int StkBiz;             //֤ȯҵ��    STK_BIZ         SMALLINT   8842
        public int StkBizAction;       //֤ȯҵ����Ϊ  STK_BIZ_ACTION  SMALLINT   40  
        public int OrderDate;          //ί������    ORDER_DATE      INTEGER    8834��Ȩר���ֶ�
        public int OrderSn;            //ί�����    ORDER_SN        INTEGER    8832��Ȩר���ֶ�
        public int IntOrg;             //�ڲ�����    INT_ORG         SMALLINT   8911��Ȩר���ֶ�
        public string Stkpbu;      //���׵�Ԫ    STKPBU          VARCHAR(8) 8843��Ȩר���ֶ�
        public string SubacctCode; //֤ȯ�˻��ӱ��� SUBACCT_CODE    VARCHAR(8) 9099��Ȩר���ֶ�
        public string OptTrdacct; //��Ȩ��Լ�˻�  OPT_TRDACCT     VARCHAR(18)9098��Ȩר���ֶ�
        public string OwnerType;   //������������  OWNER_TYPE      CHAR(3)    9091��Ȩר���ֶ�
        public string OptCode;    //��Լ����    OPT_CODE        VARCHAR(32)9083��Ȩר���ֶ�
        public string OptName;    //��Լ���    OPT_NAME        VARCHAR(32)9084��Ȩר���ֶ�
        public byte Currency;          //���Ҵ���    CURRENCY        CHAR(1)    15  ��Ȩר���ֶ�
        public byte OptUndlCls;        //���֤ȯ���  OPT_UNDL_CLS    CHAR(1)    9085��Ȩר���ֶ�
        public string OptUndlCode; //���֤ȯ����  OPT_UNDL_CODE   VARCHAR(8) 9086��Ȩר���ֶ�
        public string OptUndlName;//���֤ȯ����  OPT_UNDL_NAME   VARCHAR(16)9087��Ȩר���ֶ�
        public string OrderPrice;  //ί�м۸�    ORDER_PRICE     CPRICE4    44  ��Ȩר���ֶ�
        public long OrderQty;          //ί������    ORDER_QTY       BIGINT     38  ��Ȩר���ֶ�
        public string OrderAmt;    //ί�н��    ORDER_AMT       CMONEY     8830��Ȩר���ֶ�
        public string MatchedAmt;  //�ѳɽ����   MATCHED_AMT     CMONEY     8504��Ȩר���ֶ�
        public string MarginPreFrz;//Ԥռ�ñ�֤��  MARGIN_PRE_FRZ  CMONEY     9094��Ȩר���ֶΣ�����ί��ʱ��дԤ����ı�֤�����������0����
        public string MarginFrz;   //ռ�ñ�֤��   MARGIN_FRZ      CMONEY     9095��Ȩר���ֶΣ������ɽ�ʱ��дʵ�ʶ���ı�֤�����������0����
        public string MarginPreUfz;//Ԥ�ͷű�֤��  MARGIN_PRE_UFZ  CMONEY     9096��Ȩר���ֶΣ���ƽί��ʱ��дԤ�ⶳ�ı�֤�����������0����
        public string MarginUfz;   //�ͷű�֤��   MARGIN_UFZ      CMONEY     9097��Ȩר���ֶΣ���ƽ�ɽ�ʱ��дʵ�ʽⶳ�ı�֤�����������0����
        public int ErrorId;            //�������    ERROR_ID        SMALLINT   8900�������
        public string ErrorMsg;   //������Ϣ    ERROR_MSG       VARCHAR(81)8901������Ϣ
        public string BrokerId;   //���͹�˾����  BROKER_ID       VARCHAR(11)8890���͹�˾����
        public string InstrumentId;//��Լ����    INSTRUMENT_ID   VARCHAR(31)48  ��Լ����
        public string OrderRef;   //��������    ORDER_REF       VARCHAR(13)8738��������
        public string UserId;     //�û�����    USER_ID         VARCHAR(16)9080�û�����
        public string ExchangeId;  //����������   EXCHANGE_ID     VARCHAR(9) 207 ����������
        public string OrderSysId; //�������    ORDER_SYS_ID    VARCHAR(21)8745�������
        public string CombOffsetFlag;//��Ͽ�ƽ��־  COMB_OFFSET_FLAGVARCHAR(5) 8741��Ͽ�ƽ��־
        public string CombHedgeFlag;//���Ͷ���ױ���־COMB_HEDGE_FLAG VARCHAR(5) 8742���Ͷ���ױ���־
        public string OrderLocalId;//���ر������  ORDER_LOCAL_ID  VARCHAR(13)8722���ر������
        public int SequenceNo;         //���      SEQUENCE_NO     SMALLINT   8832���
        public string CliOrderNo; //�ͻ���ί�б�� CLI_ORDER_NO    VARCHAR(32)9102
        public string StkName; //֤ȯ���� STK_NAME VARCHAR(16) 55
        public long TotalMatchedQty;      //�ѳɽ�����   TOTAL_MATCHED_QTY   BIGINT     9100�ѳɽ�����
        public long WithdrawnQty;      //�ѳ�������   WITHDRAWN_QTY   BIGINT     8837�ѳ�������
        public string TotalMatchedAmt; //�ۼƳɽ���� TOTAL_MATCHED_AMT CPRICE   9101�ۼƳɽ����
        public long MatchBuyQty;       //��ɽ����� MATCH_BUY_QTY 9152
        public long MatchSellQty;       //���ɽ����� MATCH_SELL_QTY 9153
        public string MatchBuyAmt;       //��ɽ���� MATCH_BUY_AMT 9154
        public string MatchSellAmt;       //���ɽ���� MATCH_SELL_AMT 9155
        public string MatchBuyAvgPrice;       //��ɽ����� MATCH_BUY_AVG_PRICE 9156
        public string MatchSellAvgPrice;       //���ɽ����� MATCH_SELL_AVG_PRICE 9157
        public string WithdrawnBuyQty;       //�򳷵����� WITHDRAWN_BUY_QTY 9158
        public string WithdrawnSellQty;       //�򳷵����� WITHDRAWN_SELL_QTY 9158

        public override string ToString()
        {
            return String.Format(@"Ʒ������:{0},�ɽ����:{1},�����г�:{2},֤ȯ����:{3},֤ȯ����:{4},ί�б��:{5},��ͬ���:{6},�����˻�:{7},�ɽ�����:{8},�ɽ��۸�:{9}," +
                "ί�ж�����:{10},ʵʱ������:{11},�ʽ���ý��:{12},֤ȯ��������:{13},�Է�ϯλ:{14},�Է������˺�:{15},�ɽ�����:{16},�ɽ�ʱ��:{17}," +
                "������־:{18},�ͻ�����:{19},�ʲ��˻�:{20},ί������:{21},�˻����:{22},���װ��:{23},�ɽ�����:{24},ί��״̬:{25}," +
                "֤ȯҵ��:{26},֤ȯҵ����Ϊ:{27},ί������:{28},ί�����:{29},�ڲ�����:{30},���׵�Ԫ:{31},֤ȯ�˻��ӱ���:{32},��Ȩ��Լ�˻�:{33}," +
                "������������:{34},��Լ����:{35},��Լ���:{36},���Ҵ���:{37},���֤ȯ���:{38},���֤ȯ����:{39},���֤ȯ����:{40},ί�м۸�:{41}," +
                "ί������:{42},ί�н��:{43},�ѳɽ����:{44},Ԥռ�ñ�֤��:{45},ռ�ñ�֤��:{46},Ԥ�ͷű�֤��:{47},�ͷű�֤��:{48},�������:{49}," +
                "������Ϣ:{50},���͹�˾����:{51},��Լ����:{52},��������:{53},�û�����:{54},����������:{55},�������:{56},��Ͽ�ƽ��־:{57}," +
                "���Ͷ���ױ���־:{58},���ر������:{59},���:{60},�ͻ���ί�б��:{61},�ѳɽ�����:{62},�ѳ�������:{63},�ۼƳɽ����:{64}",
                TrdCodeCls, MatchedSn, ((char)Stkex).ToString(), StkCode, StkName, OrderNo, OrderId, Trdacct, MatchedQty, MatchedPrice,
                OrderFrzAmt, RltSettAmt, FundAvl, StkAvl, OpptStkpbu, OpptTrdacct, MatchedDate, MatchedTime,
                ((char)IsWithdraw).ToString(), CustCode, CuacctCode, OrderBsn, CuacctSn, Stkbd, ((char)MatchedType).ToString(), ((char)OrderStatus).ToString(),
                StkBiz, StkBizAction, OrderDate, OrderSn, IntOrg, Stkpbu, SubacctCode, OptTrdacct,
                OwnerType, OptCode, OptName, ((char)Currency).ToString(), ((char)OptUndlCls).ToString(), OptUndlCode, OptUndlName, OrderPrice,
                OrderQty, OrderAmt, MatchedAmt, MarginPreFrz, MarginFrz, MarginPreUfz, MarginUfz, ErrorId,
                ErrorMsg, BrokerId, InstrumentId, OrderRef, UserId, ExchangeId, OrderSysId, CombOffsetFlag,
                CombHedgeFlag, OrderLocalId, SequenceNo, CliOrderNo, TotalMatchedQty, WithdrawnQty, TotalMatchedAmt);
        }
    }

    //����ί��ȷ�ϻر�
    public struct RtnTsuOrderField
    {
        public int OrderBsn; // ί������ 
        public string OrderId; // ��ͬ��� 
        public string CuacctCode; // �ʲ��˻� 
        public string OrderPrice; // ί�м۸� 
        public long OrderQty; // ί������ 
        public string OrderAmt; // ί�н�� 
        public string OrderFrzAmt; // ������ 
        public string Stkpbu; // ���׵�Ԫ 
        public string Stkbd; // ���װ�� 
        public string StkCode; // ֤ȯ���� 
        public string StkName; // ֤ȯ���� 
        public int StkBiz; // ֤ȯҵ�� 
        public int StkBizAction; // ҵ����Ϊ 
        public int CuacctSn; // �˻���� 
        public int OrderNo; // ί�б�� 
        public int OrderDate; // ί������ 
        public string OrderTime; // ί��ʱ�� 
        public string Trdacct; // �����˻� 
        public string OptNum; // ��Լ���� 
        public string OptCode; // ��Լ���� 
        public string OptName; // ��Լ��� 
        public string OptUndlCode; // ���֤ȯ���� 
        public byte ExeStatus; // ִ��״̬ 
        public int FrontId; // ǰ�ñ�� 
        public long SessionId; // �Ự��� 
        public int ErrorId; // ������� 
        public string ErrorMsg; // ������Ϣ 
        public int OrderChange; // �ĵ���ʶ 
        public string CliOrderNo; // �ͻ���ί�б�� 
        public byte CuacctType; // �˻����� 
        public int AttrCode; // ���Դ��� 
        public string TriggerPrice; // �����۸� 
        public string CustCode; // �ͻ����� 
        public int OrderGroupNo; // ��ϵ���� 
        public int SubOrderSn; // �ӵ���� 
        public int TrdDate; // �������� 
        public int MainTrdDate; // ĸ�������� 
        public string OrderAttr; // �߼����� 
        public string TrdExInfo; // ����ִ����Ϣ 
        public byte UpdownCtrl; // ��ͣ������ͣ�����־ 
        public byte Stkex; // �����г� 
        public byte TrdCodeCls; // ֤ȯ�������� 
        public string StopPrice; // ֹ��� 
        public string TrackMatchPrice; // ��̬������ 
        public int IntOrg; // �ڲ����� 
        public string ExeInfo; // ִ����Ϣ 
        public byte OnoffFlag; // ��ͣ��־ 
        public byte Channel; // �������� 
        public byte StrategyType; // �������� 
        public string StrategyName; // �������� 
        public string CliRemark; // ������Ϣ 
        public string CliDefine1; // �ͻ��Զ���1 
        public string CliDefine2; // �ͻ��Զ���2 
        public string CliDefine3; // �ͻ��Զ���3 
        public string Remark1; // Ԥ���ֶ�1 ��Ȩר���ֶ�
        public string Remark2; // Ԥ���ֶ�2 
        public string Remark3; // Ԥ���ֶ�3 
        public string Remark4; // Ԥ���ֶ�4 
        public string Remark5; // Ԥ���ֶ�5 
        public string Remark6; // Ԥ���ֶ�6 ���Ӷ���ר���ֶ�
        public string Remark7; // Ԥ���ֶ�7 ���Ӷ���ר���ֶ�
        public string Remark8; // Ԥ���ֶ�8 ���Ӷ���ר���ֶ�
        public string Remark9; // Ԥ���ֶ�9 ���Ӷ���ר���ֶ�
        public string Remarka; // Ԥ���ֶ�A ���Ӷ���ר���ֶ�

        public override string ToString()
        {
            return String.Format(@"ί������:{0},��ͬ���:{1},ί�б��:{2},ί������:{3},ί��ʱ��:{4},�ʽ��˺�:{5},ί�м۸�:{6},ί������:{7},ί�н��:{8},������:{9}," +
                "���׵�Ԫ:{10},���װ��:{11},֤ȯ����:{12},֤ȯ����:{13},֤ȯҵ��:{14},ҵ����Ϊ:{15},֤ȯ�˻�:{16},�˻����:{17},��Լ����:{18},��Լ����:{19}," +
                "��Լ���:{20},���֤ȯ����:{21},ִ��״̬:{22},ǰ�ñ��:{23},�Ự���:{24},�������:{25},������Ϣ:{26},�ĵ���ʶ:{27},�ͻ���ί�б��:{28}",
                OrderBsn, OrderId, OrderNo, OrderDate, OrderTime, CuacctCode, OrderPrice, OrderQty, OrderAmt, OrderFrzAmt,
                Stkpbu, Stkbd, StkCode, StkName, StkBiz, StkBizAction, Trdacct, CuacctSn, OptNum, OptCode,
                OptName, OptUndlCode, ((char)ExeStatus).ToString(), FrontId, SessionId, ErrorId, ErrorMsg, OrderChange, CliOrderNo);
        }
    };

    //��¼��Ϣ
    public struct LoginInfo
    {
        public string UserCode; //�û�����
        public string CuacctCode; //�ʽ��˺�
        public string CustCode; //�ͻ�����
        public string EnAuthData; //�˻���¼����
        public byte CuacctType; //�����˻�����
        public int IntOrg; //��������
        public string Channel; //����
        public string SessionId; //�Ựƾ֤
        public string ShAcct; //��A�ɶ��˻�
        public string SzAcct; //��A�ɶ��˻�

        public LoginInfo(string usercode, string cuacctcode, string custcode, byte cuaccttype, string enauthdata, int intorg, string channel, string sessionid, string shacct, string szacct)
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

    // �ն���Ϣ����
    public struct ReqClientField
    {
        public string Iip;              // ����IP
        public string Iport;             // ����IP�˿ں�
        public string Lip;              // ����IP
        public string Mac;              // MAC��ַ
        public string Hd;               // Ӳ�����к�
        public string Pcn;              // PC�ն��豸��
        public string Cpu;              // CPU���к�
        public string Pi;               // Ӳ�̷�����Ϣ
        public string Vol;              // ϵͳ�̾���
        public string Ext;              // ��չ��Ϣ �ԡ�;�����зָ�

        public ReqClientField(string iip, string iport, string lip, string mac, string hd, string pcn, string cpu, string pi, string vol, string ext)
        {
            Iip = iip;
            Iport = iport;
            Lip = lip;
            Mac = mac;
            Hd = hd;
            Pcn = pcn;
            Cpu = cpu;
            Pi = pi;
            Vol = vol;
            Ext = ext;
        }
    }

    /************������ȯ����************/
    public struct ReqFislQryCreditCustDebtsField
    {
        public long CuacctCode;                 // �ʲ��˻�
        public byte Currency;                   // ���Ҵ���
    };

    public struct RspFislQryCreditCustDebtsField
    {
        public long CustCode;                   // �ͻ�����        
        public long CuacctCode;                 // �ʲ��˻�        
        public byte Currency;                   // ���Ҵ���        
        public string FiRate;             // ��������        
        public string SlRate;             // ��ȯ����        
        public string FreeIntRate;        // ��Ϣ����        
        public byte CreditStatus;               // ����״̬        
        public string MarginRate;         // ά�ֵ�������    
        public string RealRate;           // ʵʱ��������    
        public string TotalAssert;        // ���ʲ�          
        public string TotalDebts;         // �ܸ�ծ          
        public string MarginValue;        // ��֤��������  
        public string FundAvl;            // �ʽ���ý��    
        public string FundBln;            // �ʽ����        
        public string SlAmt;              // ��ȯ���������ʽ�
        public string GuaranteOut;        // ��ת�������ʲ�  
        public string ColMktVal;          // ����֤ȯ��ֵ    
        public string FiAmt;              // ���ʱ���        
        public string TotalFiFee;         // ����Ϣ��        
        public string FiTotalDebts;       // ���ʸ�ծ�ϼ�    
        public string SlMktVal;           // Ӧ����ȯ��ֵ    
        public string TotalSlFee;         // ��ȯϢ��        
        public string SlTotalDebts;       // ��ȯ��ծ�ϼ�    
        public string FiCredit;           // �������Ŷ��    
        public string FiCreditAvl;        // ���ʿ��ö��    
        public string FiCreditFrz;        // ���ʶ�ȶ���    
        public string SlCredit;           // ��ȯ���Ŷ��    
        public string SlCreditAvl;        // ��ȯ���ö��    
        public string SlCreditFrz;        // ��ȯ��ȶ���    
        public string Rights;             // ����Ȩ��        
        public string RightsUncomer;      // ����Ȩ�棨��;��
        public long RightsQty;                  // ���Ȩ��        
        public long RightsQtyUncomer;           // ���Ȩ�棨��;��
        public string TotalCredit;        // �ܶ��          
        public string TotalCteditAvl;     // �ܿ��ö��
        public string FiUsedMargin;     //����ռ�ñ�֤��
        public string SlUsedMargin;     //��ȯռ�ñ�֤��
        public string OpenFiMtkConVal;     //δ�˽�������ֵ����
        public string FiContractPlval;    //����ӯ��
        public string SlContractPlval;    //��ȯӯ��
        public string Mayrepay;           //ֱ�ӻ�����ý��
        public string StkValue;          //֤ȯ��ֵ

        public override string ToString()
        {
            return String.Format(@"�ͻ�����:{0}, �ʲ��˻�:{1}, ���Ҵ���:{2}, ��������:{3}, ��ȯ����:{4}, ��Ϣ����:{5}, ����״̬:{6}, ά�ֵ�������:{7}, ʵʱ��������:{8}, " +
                "���ʲ�:{9}, �ܸ�ծ:{10}, ��֤��������:{11}, �ʽ���ý��:{12}, �ʽ����:{13}, ��ȯ���������ʽ�:{14}, ��ת�������ʲ�:{15}, ����֤ȯ��ֵ:{16}, ���ʱ���:{17}, " +
                "����Ϣ��:{18}, ���ʸ�ծ�ϼ�:{19}, Ӧ����ȯ��ֵ:{20}, ��ȯϢ��:{21}, ��ȯ��ծ�ϼ�:{22}, �������Ŷ��:{23}, ���ʿ��ö��:{24}, ���ʶ�ȶ���:{25}, ��ȯ���Ŷ��:{26}, " +
                "��ȯ���ö��:{27}, ��ȯ��ȶ���:{28}, ����Ȩ��:{29}, ����Ȩ�棨��;��:{30}, ���Ȩ��:{31}, ���Ȩ�棨��;��:{32}, �ܶ��:{33}, �ܿ��ö��:{34}, ����ռ�ñ�֤��:{35}, ��ȯռ�ñ�֤��:{36}" +
                "δ�˽�������ֵ����:{37}, ����ӯ��:{38}, ��ȯӯ��:{39}, ֱ�ӻ������:{40}, ֤ȯ��ֵ:{41}",
                CustCode, CuacctCode, ((char)Currency).ToString(), FiRate, SlRate, FreeIntRate, ((char)CreditStatus).ToString(), MarginRate, RealRate, 
                TotalAssert, TotalDebts, MarginValue, FundAvl, FundBln, SlAmt, GuaranteOut, ColMktVal, FiAmt, 
                TotalFiFee, FiTotalDebts, SlMktVal, TotalSlFee, SlTotalDebts, FiCredit, FiCreditAvl, FiCreditFrz, SlCredit,
                SlCreditAvl, SlCreditFrz, Rights, RightsUncomer, RightsQty, RightsQtyUncomer, TotalCredit, TotalCteditAvl, FiUsedMargin, SlUsedMargin,
                OpenFiMtkConVal, FiContractPlval, SlContractPlval, Mayrepay, StkValue);
        }
    };
}
