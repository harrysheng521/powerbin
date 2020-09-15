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
    // �ֻ���¼
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

    public struct RspAcctLogin
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

    // ֤ȯ��Ϣ��ѯ��10301036��
    public struct ReqStkInfoField
    {
        public string Stkbd;              // ���װ��
        public string StkCode;              // ���װ��
        public byte QueryFlag;             // ��ѯ����
        public string QueryPos;              // ��λ��
        public int QueryNum;              // ��ѯ����,���1000
    }

    public struct RspStkInfoField
    {
        public string QueryPos;           // ��λ��
        public string Stkbd;              // ���װ��
        public string StkCode;            // ֤ȯ����
        public string StkName;            // ֤ȯ����
        public byte StkCls;             // ֤ȯ���
        public int StkCirculation;     // ��ͨ��
        public string StkUplmtPrice;      // ��ͣ��
        public string StkLwlmtPrice;      // ��ͣ��
        public int StkLotSize;         // ÿ������
        public byte StkSuspended;       //ͣ�Ʊ�־
        public byte StkStatus;          //֤ȯ״̬

        public override string ToString()
        {
            return String.Format(@"��λ��:{0},���װ��:{1},֤ȯ����:{2},֤ȯ����:{3},֤ȯ���:{4}," +
                "��ͨ��:{5},��ͣ��:{6},��ͣ��:{7},ÿ������:{8},ͣ�Ʊ�־:{9},֤ȯ״̬:{10}",
                QueryPos, Stkbd, StkCode, StkName, ((char)StkCls).ToString(), StkCirculation,
                StkUplmtPrice, StkLwlmtPrice, StkLotSize, ((char)StkSuspended).ToString(), ((char)StkStatus).ToString());
        }
    }

    // 10302001:ί��
    public struct ReqStkOrderField
    {
        public long CustCode; //�ͻ�����
        public long CuacctCode; //�ʲ��˻�
        public string Stkbd; //���װ��
        public string StkCode; //֤ȯ����
        public string OrderPrice; //ί�м۸�
        public long OrderQty; //ί������
        public int StkBiz; //֤ȯҵ��
        public int StkBizAction; //ҵ����Ϊ
        public string Stkpbu; //���׵�Ԫ
        public int OrderBsn; //ί������
        public string OrderText; //ί����չ
        public string ClientInfo; //�ն���Ϣ
        public byte SecurityLevel; //��ȫ�ֶ�
        public string SecurityInfo; //��ȫ��Ϣ
        public string ComponetStkCode; //�ɷݹɴ���
        public string ComponetStkbd; //�ɷݹɰ��
        public string StkbdLink; //�������
        public string Trdacct; //֤ȯ�˻�
        public int CuacctSn; //�˻����
        public byte PublishCtrlFlag; //��Ʊ��ر�־
        public string RepayOrderId; //������ͬ���
        public int RepayOpeningDate; //������Լ����
        public string RepayStkCode; //����֤ȯ����
        public string TrdacctLink; //�����ɶ�
        public string InitTrdAmt; //��ʼ���׽��
        public int RepchDay; //��������
        public string LoanerTrdacct; //������֤ȯ�˻�
        public string RepaySno; //��Լ���
        public int Itemno; //��Լ���
        public byte OutputDelayFlag; //���ʱ�ӱ�־
        public byte CloseOutMode; //ƽ�ַ�ʽ
        public byte RtgsFlag; //�Ƿ�����RTGS
        public string MeetingSeq; //�ɶ�������
        public string VoteId; //�鰸���
        public string OppLofCode; //ת�뷽�������
    }

    public struct RspStkOrderField
    {
        public int OrderBsn; //ί������
        public string OrderId; //��ͬ���
        public long CuacctCode; //�ʲ��˻�
        public string OrderPrice; //ί�м۸�
        public long OrderQty; //ί������
        public string OrderAmt; //ί�н��
        public string OrderFrzAmt; //������
        public string Stkpbu; //���׵�Ԫ
        public string Stkbd; //���װ��
        public string StkCode; //֤ȯ����
        public string StkName; //֤ȯ����
        public int StkBiz; //֤ȯҵ��
        public int StkBizAction; //ҵ����Ϊ
        public string Trdacct; //֤ȯ�˻�
        public int CuacctSn; //�˻����
        public override string ToString()
        {
            return String.Format(@"ί������:{0}, ��ͬ���:{1}, �ʲ��˻�:{2}, ί�м۸�:{3}, ί������:{4}, ί�н��:{5}, ������:{6}, ���׵�Ԫ:{7}, ���װ��:{8}, ֤ȯ����:{9}, ֤ȯ����:{10}," + 
                "֤ȯҵ��:{11}, ҵ����Ϊ:{12}, ֤ȯ�˻�:{13}, �˻����:{14}",
                OrderBsn, OrderId, CuacctCode, OrderPrice, OrderQty, OrderAmt, OrderFrzAmt, Stkpbu, Stkbd, StkCode, StkName, 
                StkBiz, StkBizAction, Trdacct, CuacctSn);
        }
    }

    //103802004:ί�г���
    public struct ReqStkCancelOrderField
    {
        public long CuacctCode; //�ʲ��˻�
        public string Stkbd; //���װ��
        public string OrderId; //��ͬ���
        public int OrderBsn; //ί������
        public string ClientInfo; //�ն���Ϣ
    }

    public struct RspStkCancelOrderField
    {
        public int OrderBsn; //ί������
        public string OrderId; //��ͬ���
        public long CuacctCode; //�ʲ��˻�
        public string OrderPrice; //ί�м۸�
        public long OrderQty; //ί������
        public string OrderAmt; //ί�н��
        public string OrderFrzAmt; //������
        public string Stkpbu; //���׵�Ԫ
        public string Stkbd; //���װ��
        public string StkCode; //֤ȯ����
        public string StkName; //֤ȯ����
        public int StkBiz; //֤ȯҵ��
        public int StkBizAction; //ҵ����Ϊ
        public byte CancelStatus; //�ڲ�������־
        public string Trdacct; //֤ȯ�˻�
        public string MsgOk; //�ڳ���Ϣ
        public string CancelList; //�����б�
        public string WtOrderId; //ί�к�ͬ��
        public override string ToString()
        {
            return String.Format(@"ί������:{0}, ��ͬ���:{1}, �ʲ��˻�:{2}, ί�м۸�:{3}, ί������:{4}, ί�н��:{5}, ������:{6}, ���׵�Ԫ:{7}, ���װ��:{8}, ֤ȯ����:{9}, ֤ȯ����:{10}," + 
                "֤ȯҵ��:{11}, ҵ����Ϊ:{12}, �ڲ�������־:{13}, ֤ȯ�˻�:{14}, �ڳ���Ϣ:{15}, �����б�:{16}, ί�к�ͬ��:{17}",
                OrderBsn, OrderId, CuacctCode, OrderPrice, OrderQty, OrderAmt, OrderFrzAmt, Stkpbu, Stkbd, StkCode, StkName,
                StkBiz, StkBizAction, ((char)CancelStatus).ToString(), Trdacct, MsgOk, CancelList, WtOrderId);
        }

    }

    //10303003:ί�в�ѯ
    public struct ReqStkOrderInfoField
    {
        public long CustCode; //�ͻ�����
        public long CuacctCode; //�ʲ��˻�
        public string Stkbd; //���װ��
        public string StkCode; //֤ȯ����
        public string OrderId; //��ͬ���
        public int OrderBsn; //ί������
        public string Trdacct; //�����˻�
        public byte QueryFlag; //��ѯ����
        public string QueryPos; //��λ��
        public int QueryNum; //��ѯ����
        public int CuacctSn; //�˻����
        public byte Flag; //��ѯ��־

    };

    public struct RspStkOrderInfoField
    {
        public string QryPos; //��λ����ѯ
        public int IntOrg; //�ڲ�����
        public int TrdDate; //��������
        public int OrderDate; //ί������
        public string OrderTime; //ί��ʱ��
        public string OrderId; //��ͬ���
        public byte OrderStatus; //ί��״̬
        public byte OrderValidFlag; //ί����Ч��־
        public long CustCode; //�ͻ�����
        public long CuacctCode; //�ʲ��˻�
        public string Stkbd; //���װ��
        public string Stkpbu; //���׵�Ԫ
        public int StkBiz; //֤ȯҵ��
        public int StkBizAction; //ҵ����Ϊ
        public string StkCode; //֤ȯ����
        public string StkName; //֤ȯ����
        public byte Currency; //���Ҵ���
        public string BondInt; //ծȯ��Ϣ
        public string OrderPrice; //ί�м۸�
        public long OrderQty; //ί������
        public string OrderAmt; //ί�н��
        public string OrderFrzAmt; //ί�ж�����
        public string OrderUfzAmt; //ί�нⶳ���
        public long OfferQty; //�걨����
        public int OfferStime; //�걨ʱ��
        public long WithdrawnQty; //�ѳ�������
        public long MatchedQty; //�ѳɽ�����
        public byte IsWithdraw; //������־
        public byte IsWithdrawn; //�ѳ�����־
        public int OrderBsn; //ί������
        public string MatchedAmt; //�ɽ����
        public string Trdacct; //�����˻�
        public int CuacctSn; //�˻����
        public string RawOrderId; //ԭ��ͬ���
        public string OfferRetMsg; //�걨��Ϣ
        public string OpSite; //����վ��
        public byte Channel; //��������
        public string RltSettAmt; //ʵʱ������
        public override string ToString()
        {
            return String.Format(@"��λ����ѯ:{0}, �ڲ�����:{1}, ��������:{2}, ί������:{3}, ί��ʱ��:{4}, ��ͬ���:{5}, ί��״̬:{6}, ί����Ч��־:{7}, �ͻ�����:{8}, �ʲ��˻�:{9}, ���װ��:{10}," + 
                "���׵�Ԫ:{11}, ֤ȯҵ��:{12}, ҵ����Ϊ:{13}, ֤ȯ����:{14}, ֤ȯ����:{15}, ���Ҵ���:{16}, ծȯ��Ϣ:{17}, ί�м۸�:{18}, ί������:{19}, ί�н��:{20}," + 
                "ί�ж�����:{21}, ί�нⶳ���:{22}, �걨����:{23}, �걨ʱ��:{24}, �ѳ�������:{25}, �ѳɽ�����:{26}, ������־:{27}, �ѳ�����־:{28}, ί������:{29}, �ɽ����:{30}," + 
                "�����˻�:{31}, �˻����:{32}, ԭ��ͬ���:{33}, �걨��Ϣ:{34}, ����վ��:{35}, ��������:{36}, ʵʱ������:{37}",
                QryPos, IntOrg, TrdDate, OrderDate, OrderTime, OrderId, ((char)OrderStatus).ToString(), ((char)OrderValidFlag).ToString(), CustCode, CuacctCode, Stkbd,
                Stkpbu, StkBiz, StkBizAction, StkCode, StkName, ((char)Currency).ToString(), BondInt, OrderPrice, OrderQty, OrderAmt,
                OrderFrzAmt, OrderUfzAmt, OfferQty, OfferStime, WithdrawnQty, MatchedQty, ((char)IsWithdraw).ToString(), ((char)IsWithdrawn).ToString(), OrderBsn, MatchedAmt, Trdacct, CuacctSn, RawOrderId, OfferRetMsg, OpSite, ((char)Channel).ToString(), RltSettAmt);
        }

    };

    //10303004�ɽ���ѯ
    public struct ReqStkMatchInfoField
    {
        public long CustCode; //�ͻ�����
        public long CuacctCode; //�ʲ��˻�
        public string Stkbd; //���װ��
        public string StkCode; //֤ȯ����
        public string OrderId; //��ͬ���
        public int OrderBsn; //ί������
        public string Trdacct; //�����˻�
        public byte QueryFlag; //��ѯ����
        public string QueryPos; //��λ��
        public int QueryNum; //��ѯ����
        public int CuacctSn; //�˻����
        public byte Flag; //��ѯ��־
    };

    public struct RspStkMatchInfoField
    {
        public string QryPos; //��λ����ѯ
        public string MatchedTime; //�ɽ�ʱ��
        public int OrderDate; //ί������
        public int OrderSn; //ί�����
        public int OrderBsn; //ί������
        public string OrderId; //��ͬ���
        public int IntOrg; //�ڲ�����
        public long CustCode; //�ͻ�����
        public long CuacctCode; //�ʲ��˻�
        public string Stkbd; //���װ��
        public string Stkpbu; //���׵�Ԫ
        public string StkTrdacct; //֤ȯ�˻�
        public int StkBiz; //֤ȯҵ��
        public int StkBizAction; //֤ȯҵ����Ϊ
        public string StkCode; //֤ȯ����
        public string StkName; //֤ȯ����
        public byte Currency; //���Ҵ���
        public string BondInt; //ծȯ��Ϣ
        public string OrderPrice; //ί�м۸�
        public long OrderQty; //ί������
        public string OrderAmt; //ί�н��
        public string OrderFrzAmt; //ί�ж�����
        public string MatchedSn; //�ɽ����
        public string MatchedPrice; //�ɽ��۸�
        public string MatchedQty; //�ѳɽ�����
        public string MatchedAmt; //�ѳɽ����
        public byte MatchedType; //�ɽ�����
        public int CuacctSn; //�˻����
        public byte IsWithdraw; //������־
        public byte OrderStatus; //ί��״̬
        public string RltSettAmt; //ʵʱ������
        public override string ToString()
        {
            return String.Format(@"��λ����ѯ:{0}, �ɽ�ʱ��:{1}, ί������:{2}, ί�����:{3}, ί������:{4}, ��ͬ���:{5}, �ڲ�����:{6}, �ͻ�����:{7}, �ʲ��˻�:{8}, ���װ��:{9}, ���׵�Ԫ:{10}," + 
                "֤ȯ�˻�:{11}, ֤ȯҵ��:{12}, ֤ȯҵ����Ϊ:{13}, ֤ȯ����:{14}, ֤ȯ����:{15}, ���Ҵ���:{16}, ծȯ��Ϣ:{17}, ί�м۸�:{18}, ί������:{19}, ί�н��:{20}," + 
                "ί�ж�����:{21}, �ɽ����:{22}, �ɽ��۸�:{23}, �ѳɽ�����:{24}, �ѳɽ����:{25}, �ɽ�����:{26}, �˻����:{27}, ������־:{28}, ί��״̬:{29}, ʵʱ������:{30}",
                QryPos, MatchedTime, OrderDate, OrderSn, OrderBsn, OrderId, IntOrg, CustCode, CuacctCode, Stkbd, Stkpbu,
                StkTrdacct, StkBiz, StkBizAction, StkCode, StkName, ((char)Currency).ToString(), BondInt, OrderPrice, OrderQty, OrderAmt,
                OrderFrzAmt, MatchedSn, MatchedPrice, MatchedQty, MatchedAmt, ((char)MatchedType).ToString(), CuacctSn, ((char)IsWithdraw).ToString(), ((char)OrderStatus).ToString(), RltSettAmt);
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
        public string StktPrice; // �ɱ��۸�
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
                StkPcostRlt, StkPlamt, StkPlamtRlt, MktVal, StktPrice, ProIncome,
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
        public string OpSite; //����վ��

        public LoginInfo(string usercode, string cuacctcode, string custcode, byte cuaccttype, string enauthdata, int intorg, string channel, string sessionid, string shacct, string szacct, string opSite)
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
            OpSite = opSite;
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

}
