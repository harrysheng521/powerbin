// �ļ���������ȨAPI���ܽṹ�嶨��
//--------------------------------------------------------------------------------------------------
// �޸�����      �汾          ����            ��ע
//--------------------------------------------------------------------------------------------------
// 2020/6/12    001.000.001  SHENGHB          ����
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
    //-------------------------------10314001:�û���¼------------------------------------
    public struct ReqOptUserLoginField
    {
        public string AcctType;          // �˻����� 'U':�ͻ����� 'Z':�ʲ��˻�
        public string AcctId;           // �˻���ʶ
        public byte  UseScope;                 // ʹ�÷�Χ '4':��Ȩ��������
        public byte  AuthType;                 // ��֤���� '0':����
        public string AuthData;        // ��֤����(����)
        public byte  EncryptType;              // ���ܷ�ʽ ��0��:��֤KBSSϵͳ���� ��1��:��֤Win�漯�н��׼��� ��2��:��֤Unix�漯�н��׼��� ��3��:�ⲿ�ؼ��� ��4�� : �ⲿ����
        public string EncryptKey;       // ��������
    }

    public struct RspOptUserLoginField
    {
        public long CustCode;                 // �ͻ�����
        public long CuacctCode;               // �ʲ��˻�
        public byte  Stkex;                    // �����г�
        public string Stkbd;             // ���װ��
        public string Trdacct;          // ֤ȯ�˻�
        public string SubacctCode;			// ֤ȯ�˻��ӱ���   2015/8/5
        public string OptTrdacct;			// ��Ȩ��Լ�˻�		2015/8/5
        public int IntOrg;                    // �ڲ�����
        public byte  TrdacctStatus;            // �˻�״̬
        public string Stkpbu;            // ���׵�Ԫ
        public string AcctType;          // �˻����� 'U':�ͻ����� 'Z':�ʲ��˻�
        public string AcctId;           // �˻���ʶ
        public string TrdacctName;      // �˻�����
        public string Session;         // �Ựƾ֤
        public override string ToString()
        {
            return String.Format(@"�ͻ�����:{0},�ʲ��˻�:{1},�����г�:{2},���װ��:{3},֤ȯ�˻�:{4}," +
                "֤ȯ�˻��ӱ���{5},��Ȩ��Լ�˻�:{6},�ڲ�����:{7},�˻�״̬:{8},���׵�Ԫ:{9},�˻�����:{10},�˻���ʶ:{11}," +
                "�˻�����:{12},�Ựƾ֤:{13}",
                CustCode, CuacctCode, ((char)Stkex).ToString(), Stkbd, Trdacct,
                SubacctCode, OptTrdacct, IntOrg, ((char)TrdacctStatus).ToString(), Stkpbu, AcctType, AcctId,
                TrdacctName, Session);
        }
    }

    //-------------------------------10312001:������Ȩί���걨------------------------------------
    public struct ReqOptOrderField
    {
        public long CustCode;                 // �ͻ�����
        public long CuacctCode;               // �ʲ��˻�
        public int IntOrg;                    // �ڲ�����
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Trdacct;          // ֤ȯ�˻�
        public string OptNum;           // ��Լ����
        public string OrderPrice;       // ί�м۸� CPRICE4 ��λ��Ԫ����ȷ��0.1��
        public long OrderQty;                 // ί������
        public int StkBiz;                    // ֤ȯҵ�� �ֵ�[STK_BIZ]
        public int StkBizAction;              // ֤ȯҵ����Ϊ �ֵ�[STK_BIZ_ACTION]
        public string Stkpbu;            // ���׵�Ԫ
        public int OrderBsn;                  // ί������
        public string ClientInfo;      // �ն���Ϣ ����Ӳ�̺�\CPU\��������
        public byte  SecurityLevel;            // ��ȫ�ֶ� 0:�ް�ȫ 1:У��Ʊ�� 2:У������
        public string SecurityInfo;    // ��ȫ�ֶ�ΪУ��Ʊ��������дƱ��,��ȫ�ֶ�Ϊ����������д������������
        public string OrderIdEx;        // �����Ϊ�ⲿ���룬��Ȩϵͳ�����κδ���
        public byte  EncryptType;	     //2015/8/3��� ���ܷ�ʽ
        public string EncryptKey;	//2015/8/3���  ��������
    }

    public struct RspOptOrderField
    {
        public int OrderBsn;                  // ί������
        public string OrderId;          // ��ͬ���
        public long CuacctCode;               // �ʲ��˻�
        public string OrderPrice;       // ί�м۸� CPRICE4
        public long OrderQty;                 // ί������
        public string OrderAmt;			// ί�н��
        public string OrderFrzAmt;      // ί�ж�����
        public string Stkpbu;            // ���׵�Ԫ
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Trdacct;          // ֤ȯ�˻�
        public string SubacctCode;       // ֤ȯ�˻��ӱ���
        public string OptTrdacct;	 //2015/8/3�����Ȩ��Լ�˻� 
        public string OptNum;           // ��Լ����
        public string OptCode;          // ��Լ����
        public string OptName;          // ��Լ���
        public string OptUndlCode;       // ���֤ȯ����
        public string OptUndlName;      // ���֤ȯ����
        public int StkBiz;					// ֤ȯҵ��
        public int StkBizAction;				// ֤ȯҵ����Ϊ
        public string OrderIdEx;        // �ⲿ��ͬ���
        public override string ToString()
        {
            return String.Format(@"ί������:{0},��ͬ���:{1},�ʽ��˻�:{2},ί�м۸�:{3},ί������:{4},ί�н��:{5},ί�ж�����:{6},���׵�Ԫ:{7}," +
            "���װ��:{8},֤ȯ�˻�:{9},֤ȯ�˻��ӱ���:{10},��Ȩ��Լ�˻�:{11},��Լ����:{12},��Լ����:{13},���֤ȯ����:{14},���֤ȯ����:{15}," +
            "֤ȯҵ��:{16},֤ȯҵ����Ϊ:{17},�ⲿ��ͬ���:{18}",
             OrderBsn, OrderId, CuacctCode, OrderPrice, OrderQty, OrderAmt, OrderFrzAmt, Stkpbu,
             Stkbd, Trdacct, SubacctCode, OptTrdacct, OptNum, OptCode, OptUndlCode, OptUndlName,
             StkBiz, StkBizAction, OrderIdEx);
        }
    }

    //-------------------------------10310502:��Ʊ��Ȩί�г���------------------------------------
    public struct ReqOptCancelOrderField
    {
        public long CuacctCode;               // �ʲ��˻� 
        public int IntOrg;                    // �ڲ����� 
        public string Stkbd;             // ���װ�� 
        public string OrderId;          // ��ͬ��� 
        public int OrderBsn;                  // ί������ 
        public string ClientInfo;      // �ͻ�����Ϣ 1��ͨ��mid����ʱ��ֵ����͹̶����F_OP_SITE(����վ��)��ֵ����һ�£� 2��ͨ��������ʽ����ʱ��ֵ����Ϊ�գ������ֵ������͹̶����F_OP_SITE(����վ��)��ֵ����һ��
        public string OrderIdEx;        // �ⲿ��ͬ��� �����Ϊ�ⲿ���룬��Ȩϵͳ�����κδ���
        public byte  ForceWth;                 // ǿ����־ ��1-��ǿ����1-ǿ��
    }

    public struct RspOptCancelOrderField
    {
        public int OrderBsn;                  // ί������ 
        public string OrderId;          // ��ͬ��� 
        public long CuacctCode;               // �ʲ��˻� 
        public string OrderPrice;       // ί�м۸� 
        public long OrderQty;                 // ί������ 
        public string OrderAmt;         // ί�н�� 
        public string OrderFrzAmt;      // ί�ж����� 
        public string Stkpbu;            // ���׵�Ԫ 
        public string Stkbd;             // ���װ�� 
        public string Trdacct;          // ֤ȯ�˻� 
        public string SubacctCode;       // ֤ȯ�˻��ӱ��� 
        public string OptTrdacct;       // ��Ȩ��Լ�˻� 
        public string StkCode;          // ֤ȯ���� 
        public string StkName;          // ֤ȯ���� 
        public int StkBiz;                    // ֤ȯҵ�� 
        public int StkBizAction;              // ֤ȯҵ����Ϊ 
        public byte  CancelStatus;             // �ڲ�������־ 1:�ڲ����� ��1:��ͨ����
        public string OrderIdEx;        // �ⲿ��ͬ��� 
        public string OrderIdWtd;       // ������ͬ���

        public override string ToString()
        {
            return String.Format(@"ί������:{0},��ͬ���:{1},�ʽ����:{2},ί�м۸�:{3},ί������:{4},ί�н��:{5},ί�ж�����:{6},���׵�Ԫ:{7}," +
                "���װ��:{8},֤ȯ�˻�:{9},֤ȯ�˻��ӱ���:{10},��Ȩ��Լ�˻�:{11},���֤ȯ����:{12},���֤ȯ����:{13},֤ȯҵ�����:{14},֤ȯҵ����Ϊ:{15}," +
                "����״̬:{16},�ⲿ��ͬ���:{17},������ͬ���:{18}",
                OrderBsn, OrderId, CuacctCode, OrderPrice, OrderQty, OrderAmt, OrderFrzAmt, Stkpbu,
                Stkbd, Trdacct, SubacctCode, OptTrdacct, StkCode, StkName, StkBiz, StkBizAction, ((char)CancelStatus).ToString(), OrderIdEx, OrderIdWtd);
        }
    }

    //-------------------------------10313019:�����ʽ��ѯ--------------------------
    public struct ReqOptExpendableFundField
    {
        public long CustCode;                 // �ͻ����� �����ͬʱΪ��
        public long CuacctCode;               // �ʲ��˻� 
        public byte  Currency;                 // ���Ҵ��� �ֵ�[CURRENCY]
        public int ValueFlag;                 // ȡֵ��־ �ֶ����ڱ�ʶ���ɸ���ȡֵ MARKET_VALUE��FUND_VALUE�� STK_VALUE��FUND_LOAN �ĸ��ֶ��Ƿ�ȡֵ 0���������� 1��ȡMARKET_VALUEֵ 2��ȡFUND_VALUEֵ 4��ȡSTK_VALUEֵ 8��ȡFUND_LOANֵ �ɸ���ȡֵ
    }

    public struct RspOptExpendableFundField
    {
        public long CustCode;                 // �ͻ����� 
        public long CuacctCode;               // �ʲ��˻� 
        public byte  Currency;                 // ���Ҵ��� 
        public int IntOrg;                    // �ڲ����� 
        public string MarketValue;      // �ʲ���ֵ �ͻ��ʲ��ܶʵʱ�����ĵ�
        public string FundValue;        // �ʽ��ʲ� �ʽ��ʲ��ܶ�
        public string StkValue;         // ��ֵ ���ʽ��ʲ��ܶ� = ��ֵ
        public string FundPrebln;       // �ʽ�������� 
        public string FundBln;          // �ʽ���� 
        public string FundAvl;          // �ʽ���ý�� 
        public string FundFrz;          // �ʽ𶳽��� 
        public string FundUfz;          // �ʽ�ⶳ��� 
        public string FundTrdFrz;       // �ʽ��׶����� 
        public string FundTrdUfz;       // �ʽ��׽ⶳ��� 
        public string FundTrdOtd;       // �ʽ�����;��� 
        public string FundTrdBln;       // �ʽ��������� 
        public byte  FundStatus;               // �ʽ�״̬ �ֵ�[FUND_STATUS]
        public string MarginUsed;       // ռ�ñ�֤�� 
        public string MarginInclRlt;    // ��ռ�ñ�֤��(��δ�ɽ�) ������������ί��δ�ɽ�����ı�֤��(��ǰ����ۼ���)
        public string FundExeMargin;    // ��Ȩ������֤�� 
        public string FundExeFrz;       // ��Ȩ�ʽ𶳽��� 
        public string FundFeeFrz;       // �ʽ���ö����� 
        public string Paylater;         // �渶�ʽ� 
        public string PreadvaPay;       // Ԥ�Ƶ��ʽ�� ����ETF��ȨE+1��Ԥ����ʹ��
        public string ExpPenInt;        // Ԥ�Ƹ�ծ��Ϣ 
        public string FundDraw;         // �ʽ��ȡ��� 
        public string FundAvlRlt;       // �ʽ�̬���� 
        public string MarginInclDyn;    // ��̬ռ�ñ�֤��(��δ�ɽ�) ������������ί��δ�ɽ�����ı�֤��(��ʵʱ�۸����)
        public string DailyInAmt;       // ������� 
        public string DailyOutAmt;      // ���ճ��� 
        public string FundRealAvl;      // �ʽ�ʵ�ʿ��� ����֤��Ʊ��Ȩ��̨ϵͳ���ö�̬���ù���ʱ���ʽ�ʵ�ʿ���=min���ʽ���ý��ʽ�̬���ã����������ö�̬����ʱ���ʽ�ʵ�ʿ���=�ʽ���ý��

        public override string ToString()
        {
            return String.Format(@"�ͻ�����:{0},�ʲ��˻�:{1},���Ҵ���:{2},�ڲ�����:{3},�ʲ���ֵ:{4},�ʽ��ʲ�:{5},��ֵ:{6},�ʽ��������:{7},�ʽ����:{8},�ʽ���ý��:{9}," +
                "�ʽ𶳽���:{10},�ʽ�ⶳ���:{11},�ʽ��׶�����:{12},�ʽ��׽ⶳ���:{13},�ʽ�����;���:{14},�ʽ���������:{15},�ʽ�״̬:{16},ռ�ñ�֤��:{17},��ռ�ñ�֤��(��δ�ɽ�):{18},��Ȩ������֤��:{19}," +
                "��Ȩ�ʽ𶳽���:{20},�ʽ���ö�����:{21},�渶�ʽ�:{22},Ԥ�Ƶ��ʽ��:{23},Ԥ�Ƹ�ծ��Ϣ:{24},�ʽ��ȡ���:{25},�ʽ�̬����:{26},��̬ռ�ñ�֤��(��δ�ɽ�):{27},�������:{28},���ճ���:{29}," +
                "�ʽ�ʵ�ʿ���:{30}",
                CustCode, CuacctCode, ((char)Currency).ToString(), IntOrg, MarketValue, FundValue, StkValue, FundPrebln, FundBln, FundAvl,
                FundFrz, FundUfz, FundTrdFrz, FundTrdUfz, FundTrdOtd, FundTrdBln, ((char)FundStatus).ToString(), MarginUsed, MarginInclRlt, FundExeMargin,
                FundExeFrz, FundFeeFrz, Paylater, PreadvaPay, ExpPenInt, FundDraw, FundAvlRlt, MarginInclDyn, DailyInAmt, DailyOutAmt,
                FundRealAvl);
        }
    }

    //-------------------------------10313001:���ú�Լ�ʲ���ѯ------------------------------------
    public struct ReqOptExpendableCuField
    {
        public long CustCode;                 // �ͻ�����
        public long CuacctCode;               // �ʲ��˻�
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Trdacct;          // �����˻�
        public string OptNum;           // ��Լ����
        public string OptUndlCode;       // ���֤ȯ����
        public string Stkpbu;            // ���׵�Ԫ
        public byte  OptSide;                  // �ֲַ��� L-Ȩ���֣�S-����֣�C-���Ҳ��Գֲ�
        public byte  OptCvdFlag;               // ���ұ�־ 0-�Ǳ��Һ�Լ 1-���Һ�Լ
        public byte  QueryFlag;                // ��ѯ���� 0:���ȡ���� 1:��ǰȡ���� ����ȫ������
        public string QryPos;           // ��λ��
        public int QryNum;                    // ��ѯ����
    }

    public struct RspOptExpendableCuField
    {
        public string QryPos;           // ��λ��
        public long CustCode;                 // �ͻ����� 
        public long CuacctCode;               // �ʲ��˻� 
        public int IntOrg;                    // �ڲ����� 
        public byte  Stkex;                    // �����г� �ֵ�[STKEX]
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Stkpbu;            // ���׵�Ԫ 
        public string Trdacct;          // ֤ȯ�˻� 
        public string SubacctCode;       // ֤ȯ�˻��ӱ��� 
        public string OptTrdacct;       // ��Ȩ��Լ�˻� 
        public byte  Currency;                 // ���Ҵ��� 
        public string OptNum;           // ��Լ���� 
        public string OptCode;          // ��Լ���� 
        public string OptName;          // ��Լ��� 
        public byte  OptType;                  // ��Լ���� �ֵ�[OPT_TYPE]
        public byte  OptSide;                  // �ֲַ��� 
        public byte  OptCvdFlag;               // ���ұ�־ 0-�Ǳ��Һ�Լ 1-���Һ�Լ
        public long OptPrebln;                // ��Լ������� 
        public long OptBln;                   // ��Լ��� 
        public long OptAvl;                   // ��Լ�������� 
        public long OptFrz;                   // ��Լ�������� 
        public long OptUfz;                   // ��Լ�ⶳ���� 
        public long OptTrdFrz;                // ��Լ���׶������� 
        public long OptTrdUfz;                // ��Լ���׽ⶳ���� 
        public long OptTrdOtd;                // ��Լ������;���� 
        public long OptTrdBln;                // ��Լ������������ 
        public long OptClrFrz;                // ��Լ���㶳������ 
        public long OptClrUfz;                // ��Լ����ⶳ���� 
        public long OptClrOtd;                // ��Լ������;���� 
        public string OptBcost;         // ��Լ����ɱ� 
        public string OptBcostRlt;      // ��Լ����ɱ���ʵʱ�� 
        public string OptPlamt;         // ��Լӯ����� 
        public string OptPlamtRlt;      // ��Լӯ����ʵʱ�� 
        public string OptMktVal;        // ��Լ��ֵ 
        public string OptPremium;       // Ȩ���� 
        public string OptMargin;        // ��֤�� 
        public long OptCvdAsset;              // ���ҹɷ����� 
        public string OptClsProfit;     // ����ƽ��ӯ�� 
        public string SumClsProfit;     // �ۼ�ƽ��ӯ�� 
        public string OptFloatProfit;   // ����ӯ�� ����ӯ��=֤ȯ��ֵ-����ɱ�
        public string TotalProfit;      // ��ӯ�� 
        public long OptRealPosi;              // ��Լʵ�ʳֲ� 
        public long OptClsUnmatched;          // ��Լƽ�ֹҵ����� ��ƽ��ί��δ�ɽ�����
        public long OptDailyOpenRlt;          // �����ۼƿ������� 
        public string OptUndlCode;       // ���֤ȯ���� 
        public string ExerciseVal;      // ��Ȩ��ֵ �Ϲ�Ȩ���ֵ���Ȩ��ֵ��MAX((���-��Ȩ��), 0) * ��Լ��λ * ��Լ���� �Ϲ�Ȩ���ֵ���Ȩ��ֵ��MAX((��Ȩ��-��ļ�), 0) * ��Լ��λ * ��Լ����
        public long CombedQty;                // ����Ϻ�Լ���� ������ϵ���Ȩ��Լ�ֲ�����
        public string CostPrice;        // ��Լ�ɱ��� 

        public override string ToString()
        {
            return String.Format(@"��λ��:{0},�ͻ�����:{1},�ʲ��˻�:{2},�ڲ�����:{3},�����г�:{4},���װ��:{5},���׵�Ԫ:{6},֤ȯ�˻�:{7}," +
                "֤ȯ�˻��ӱ���:{8},��Ȩ��Լ�˻�:{9},���Ҵ���:{10},��Լ����:{11},��Լ����:{12},��Լ���:{13},��Լ����:{14},�ֲַ���:{15}," +
                "���ұ�־:{16},��Լ�������:{17},��Լ���:{18},��Լ��������:{19},��Լ��������:{20},��Լ�ⶳ����:{21},��Լ���׶�������:{22},��Լ���׽ⶳ����:{23}," +
                "��Լ������;����:{24},��Լ������������:{25},��Լ���㶳������:{26},��Լ����ⶳ����:{27},��Լ������;����:{28},��Լ����ɱ�:{29},��Լ����ɱ���ʵʱ��:{30},��Լӯ�����:{31}," +
                "��Լӯ����ʵʱ��:{32},��Լ��ֵ:{33},Ȩ����:{34},��֤��:{35},���ҹɷ�����:{36},����ƽ��ӯ��:{37},�ۼ�ƽ��ӯ��:{38},����ӯ��:{39}," +
                "��ӯ��:{40},��Լʵ�ʳֲ�:{41},��Լƽ�ֹҵ�����:{42},�����ۼƿ�������:{43},���֤ȯ����:{44}",
                QryPos, CustCode, CuacctCode, IntOrg, ((char)Stkex).ToString(), Stkbd, Stkpbu, Trdacct,
                SubacctCode, OptTrdacct, ((char)Currency).ToString(), OptNum, OptCode, OptName, ((char)OptType).ToString(), ((char)OptSide).ToString(),
                ((char)OptCvdFlag).ToString(), OptPrebln, OptBln, OptAvl, OptFrz, OptUfz, OptTrdFrz, OptTrdUfz,
                OptTrdOtd, OptTrdBln, OptClrFrz, OptClrUfz, OptClrOtd, OptBcost, OptBcostRlt, OptPlamt,
                OptPlamtRlt, OptMktVal, OptPremium, OptMargin, OptCvdAsset, OptClsProfit, SumClsProfit, OptFloatProfit,
                TotalProfit, OptRealPosi, OptClsUnmatched, OptDailyOpenRlt, OptUndlCode);
        }
    }

    //-------------------------------10313003:������Ȩ����ί�в�ѯ------------------------------------
    public struct ReqOptCurrDayOrderField
    {
        public long CustCode;                 // �ͻ����� �����ͬʱΪ��
        public long CuacctCode;               // �ʲ��˻�
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Trdacct;          // �����˻�
        public string OptNum;           // ��Լ����
        public string OptUndlCode;       // ���֤ȯ����
        public string CombStraCode;		// ��ϲ��Դ���        2015/8/5
        public string OrderId;          // ��ͬ���
        public int OrderBsn;                  // ί������
        public int StkBiz;                    // ֤ȯҵ�� �ֵ�[STK_BIZ]
        public int StkBizAction;              // ֤ȯҵ����Ϊ �ֵ�[STK_BIZ_ACTION]
        public byte  OrderStatus;              // ί��״̬
        public string OwnerType;         // ������������  
        public byte  QueryFlag;                // ��ѯ���� 0:���ȡ���� 1:��ǰȡ���� ����ȫ������
        public string QryPos;           // ��λ��
        public int QryNum;                    // ��ѯ����
    }

    public struct RspOptCurrDayOrderField
    {
        public string QryPos;           // ��λ��
        public int TrdDate;                   // ��������
        public int OrderDate;                 // ί������
        public string OrderTime;        // ί��ʱ��
        public int OrderBsn;                  // ί������
        public string OrderId;          // ��ͬ���
        public byte  OrderStatus;              // ί��״̬
        public byte  OrderValidFlag;           // ί����Ч��־
        public int IntOrg;                    // �ڲ�����
        public long CustCode;                 // �ͻ�����
        public long CuacctCode;               // �ʲ��˻�
        public byte  Stkex;                    // �����г� �ֵ�[STKEX]
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Stkpbu;            // ���׵�Ԫ
        public string Trdacct;          // ֤ȯ�˻�
        public string SubacctCode;       // ֤ȯ�˻��ӱ���
        public string OptTrdacct;			// ��Ȩ��Լ�˻�				2015/8/5
        public int StkBiz;                    // ֤ȯҵ�� �ֵ�[STK_BIZ]
        public int StkBizAction;              // ֤ȯҵ����Ϊ �ֵ�[STK_BIZ_ACTION]
        public string OwnerType;         // ������������
        public string OptNum;           // ��Լ����
        public string OptCode;          // ��Լ����
        public string OptName;          // ��Լ���
        public string CombNum;			// ��ϱ���				    2015/8/5       
        public string CombStraCode;		// ��ϲ��Դ���				2015/8/5
        public string Leg1Num;			// �ɷ�һ��Լ����			2015/8/5
        public string Leg2Num;			// �ɷֶ���Լ����			2015/8/5
        public string Leg3Num;			// �ɷ�����Լ����			2015/8/5
        public string Leg4Num;			// �ɷ��ĺ�Լ����			2015/8/5
        public byte  Currency;                 // ���Ҵ��� �ֵ�[CURRENCY]
        public string OrderPrice;       // ί�м۸� CPRICE4
        public long OrderQty;                 // ί������
        public string OrderAmt;         // ί�н��
        public string OrderFrzAmt;      // ί�ж�����
        public string OrderUfzAmt;      // ί�нⶳ���
        public long OfferQty;                 // �걨����
        public int OfferStime;                // �걨ʱ��
        public long WithdrawnQty;             // �ѳ�������
        public long MatchedQty;               // �ѳɽ�����
        public string MatchedAmt;       // �ѳɽ����
        public byte  IsWithdraw;               // ������־
        public byte  IsWithdrawn;              // �ѳ�����־
        public byte  OptUndlCls;               // ���֤ȯ���
        public string OptUndlCode;       // ���֤ȯ����
        public string OptUndlName;      // ���֤ȯ����
        public long UndlFrzQty;               // ���ȯί�ж�������
        public long UndlUfzQty;               // ���ȯί�нⶳ����
        public long UndlWthQty;               // ���ȯ�ѳ�������
        public string OfferRetMsg;      // �걨������Ϣ
        public string OrderIdEx;        // �ⲿ��ͬ���
        public int OrderSn;                   // ί�����
        public string RawOrderId;       // �ⲿ��ͬ���
        public string MarginPreFrz;     // Ԥռ�ñ�֤�� ����ί��ʱ��дԤ����ı�֤�����������0��
        public string MarginFrz;        // ռ�ñ�֤�� �����ɽ�ʱ��дʵ�ʶ���ı�֤�����������0��
        public string MarginPreUfz;     // Ԥ�ⶳ��֤�� ��ƽί��ʱ��дԤ�ⶳ�ı�֤�����������0��
        public string MarginUfz;        // �ⶳ��֤�� ��ƽ�ɽ�ʱ��дʵ�ʽⶳ�ı�֤�����������0��

        public override string ToString()
        {
            return String.Format(@"��λ��:{0},��������:{1},ί������:{2},ί��ʱ��:{3},ί������:{4},��ͬ���:{5},ί��״̬:{6},ί����Ч��־:{7},�ڲ�����:{8}," +
                "�ͻ�����:{9},�ʲ��˻�:{10},�����г�:{11},���װ��:{12},���׵�Ԫ:{13},֤ȯ�˻�:{14},֤ȯ�˻��ӱ���:{15},��Ȩ��Լ�˻�:{16},֤ȯҵ��:{17}," +
                "֤ȯҵ����Ϊ:{18},������������:{19},��Լ����:{20},��Լ����:{21},��Լ���:{22},��ϱ���:{23},��ϲ��Դ���:{24},�ɷ�һ:{25},�ɷֶ�:{26}," +
                "�ɷ���:{27},�ɷ���:{28},���Ҵ���:{29},ί�м۸�:{30},ί������:{31},ί�н��:{32},ί�ж�����:{33},ί�нⶳ���:{34},�걨����:{35}," +
                "�걨ʱ��:{36},�ѳ�������:{37},�ѳɽ�����:{38},�ѳɽ����:{39},������־:{40},�ѳ�����־:{41},���֤ȯ���:{42},���֤ȯ����:{43}," +
                "���֤ȯ����:{44},���ȯί�ж�������:{45},���ȯί�нⶳ����:{46},���ȯ�ѳ�������:{47},�걨������Ϣ:{48},�ⲿ��ͬ���:{49},ί�����:{50},�ⲿ��ͬ���:{51},Ԥռ�ñ�֤��:{52}," +
                "ռ�ñ�֤��:{53},Ԥ�ⶳ��֤��:{54},�ⶳ��֤��:{55}",
                QryPos, TrdDate, OrderDate, OrderTime, OrderBsn, OrderId, ((char)OrderStatus).ToString(), ((char)OrderValidFlag).ToString(), IntOrg,
                CustCode, CuacctCode, ((char)Stkex).ToString(), Stkbd, Stkpbu, Trdacct, SubacctCode, OptTrdacct, StkBiz,
                StkBizAction, OwnerType, OptNum, OptCode, OptName, CombNum, CombStraCode, Leg1Num, Leg2Num,
                Leg3Num, Leg4Num, ((char)Currency).ToString(), OrderPrice, OrderQty, OrderAmt, OrderFrzAmt, OrderUfzAmt, OfferQty,
                OfferStime, WithdrawnQty, MatchedQty, MatchedAmt, ((char)IsWithdraw).ToString(), ((char)IsWithdrawn).ToString(), ((char)OptUndlCls).ToString(), OptUndlCode, OptUndlName,
                UndlFrzQty, UndlUfzQty, UndlWthQty, OfferRetMsg, OrderIdEx, OrderSn, RawOrderId, MarginPreFrz, MarginFrz, MarginPreUfz, MarginUfz);
        }
    }

    //-------------------------------10313004:������Ȩ���ճɽ���ѯ------------------------------------
    public struct ReqOptCurrDayFillField
    {
        public long CustCode;                 // �ͻ����� �����ͬʱΪ��
        public long CuacctCode;               // �ʲ��˻�
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Trdacct;          // �����˻�
        public string OptNum;           // ��Լ����
        public string OptUndlCode;       // ���֤ȯ����
        public string CombStraCode;		// ��ϲ��Դ���    2015/8/5
        public string OrderId;          // ��ͬ���
        public int OrderBsn;                  // ί������
        public int StkBiz;                    // ֤ȯҵ�� �ֵ�[STK_BIZ]
        public int StkBizAction;              // ֤ȯҵ����Ϊ �ֵ�[STK_BIZ_ACTION]
        public string OwnerType;			// ������������    2015/8/5
        public byte  QueryFlag;                // ��ѯ���� 0:���ȡ���� 1:��ǰȡ���� ����ȫ������
        public string QryPos;           // ��λ��
        public int QryNum;                    // ��ѯ����
    }

    public struct RspOptCurrDayFillField
    {
        public string QryPos;           // ��λ��
        public int TrdDate;                   // ��������
        public string MatchedTime;       // �ɽ�ʱ��
        public int OrderDate;                 // ί������
        public int OrderSn;                   // ί�����
        public int OrderBsn;                  // ί������
        public string OrderId;          // ��ͬ���
        public int IntOrg;                    // �ڲ�����
        public long CustCode;                 // �ͻ�����
        public long CuacctCode;               // �ʲ��˻�
        public byte  Stkex;                    // �����г� �ֵ�[STKEX]
        public string Stkbd;             // ���װ�� �ֵ�[STKBD]
        public string Stkpbu;            // ���׵�Ԫ
        public string Trdacct;          // ֤ȯ�˻�
        public string SubacctCode;       // ֤ȯ�˻��ӱ���
        public string OptTrdacct;			// ��Ȩ��Լ�˻�          2015/8/5
        public int StkBiz;                    // ֤ȯҵ�� �ֵ�[STK_BIZ]
        public int StkBizAction;              // ֤ȯҵ����Ϊ �ֵ�[STK_BIZ_ACTION]
        public string OwnerType;         // ������������
        public string OptNum;           // ��Լ����
        public string OptCode;          // ��Լ����
        public string OptName;          // ��Լ���
        public string CombNum;			// ��ϱ���              2015/8/5
        public string CombStraCode;		// ��ϲ��Դ���          2015/8/5
        public string Leg1Num;			// �ɷ�һ��Լ����        2015/8/5
        public string Leg2Num;			// �ɷֶ���Լ����        2015/8/5
        public string Leg3Num;			// �ɷ�����Լ����        2015/8/5
        public string Leg4Num;			// �ɷ��ĺ�Լ����        2015/8/5
        public byte  Currency;                 // ���Ҵ��� �ֵ�[CURRENCY]
        public byte  OptUndlCls;               // ���֤ȯ���
        public string OptUndlCode;       // ���֤ȯ����
        public string OptUndlName;      // ���֤ȯ����
        public string OrderPrice;       // ί�м۸� CPRICE4
        public long OrderQty;                 // ί������
        public string OrderAmt;         // ί�н��
        public string OrderFrzAmt;      // ί�ж�����
        public byte  IsWithdraw;               // ������־
        public byte  MatchedType;              // �ɽ�����
        public string MatchedSn;        // �ɽ����
        public string MatchedPrice;     // �ɽ��۸� CPRICE4
        public long MatchedQty;               // �ѳɽ�����
        public string MatchedAmt;       // �ѳɽ����
        public string OrderIdEx;        // �ⲿ��ͬ���
        public string MarginPreFrz;     // Ԥռ�ñ�֤�� ����ί��ʱ��дԤ����ı�֤�����������0��
        public string MarginFrz;        // ռ�ñ�֤�� �����ɽ�ʱ��дʵ�ʶ���ı�֤�����������0��
        public string MarginPreUfz;     // Ԥ�ⶳ��֤�� ��ƽί��ʱ��дԤ�ⶳ�ı�֤�����������0��
        public string MarginUfz;        // �ⶳ��֤�� ��ƽ�ɽ�ʱ��дʵ�ʽⶳ�ı�֤�����������0��
        public string MatchedFee;			// �ɽ�����        2015/8/5   

        public override string ToString()
        {
            return String.Format(@"��λ��:{0},��������:{1},�ɽ�ʱ��:{2},ί������:{3},ί�����:{4},ί������:{5},��ͬ���:{6},�ڲ�����:{7},�ͻ�����:{8}," +
                "�ʲ��˻�:{9},�����г�:{10},���װ��:{11},���׵�Ԫ:{12},֤ȯ�˻�:{13},֤ȯ�˻��ӱ���:{14},��Ȩ��Լ�˻�:{15},֤ȯҵ��:{16},֤ȯҵ����Ϊ:{17}," +
                "������������:{18},��Լ����:{19},��Լ����:{20},��Լ���:{21},��ϱ���:{22},��ϲ��Դ���:{23},�ɷ�һ:{24},�ɷֶ�:{25},�ɷ���:{26}," +
                "�ɷ���:{27},���Ҵ���:{28},���֤ȯ���:{29},���֤ȯ����:{30},���֤ȯ����:{31},ί�м۸�:{32},ί������:{33},ί�н��:{34},ί�ж�����:{35}," +
                "������־:{36},�ɽ�����:{37},�ɽ����:{38},�ɽ��۸�:{39},�ѳɽ�����:{40},�ѳɽ����:{41},�ⲿ��ͬ���:{42},Ԥռ�ñ�֤��:{43},ռ�ñ�֤��:{44}," +
                "Ԥ�ⶳ��֤��:{45},�ⶳ��֤��:{46},�ɽ�����:{47}",
                QryPos, TrdDate, MatchedTime, OrderDate, OrderSn, OrderBsn, OrderId, IntOrg, CustCode,
                CuacctCode, ((char)Stkex).ToString(), Stkbd, Stkpbu, Trdacct, SubacctCode, OptTrdacct, StkBiz, StkBizAction,
                OwnerType, OptNum, OptCode, OptName, CombNum, CombStraCode, Leg1Num, Leg2Num, Leg3Num,
                Leg4Num, ((char)Currency).ToString(), OptUndlCls, OptUndlCode, OptUndlName, OrderPrice, OrderQty, OrderAmt, OrderFrzAmt,
                ((char)IsWithdraw).ToString(), ((char)MatchedType).ToString(), MatchedSn, MatchedPrice, MatchedQty, MatchedAmt, OrderIdEx, MarginPreFrz, MarginFrz,
                MarginPreUfz, MarginUfz, MatchedFee);
        }
    }

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
    public struct RtnOptOrderConfirmField
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
            return String.Format(@"�����г�:{0},֤ȯ����:{1},��ͬ���:{2},�����˻�:{3},������־:{4},�ͻ�����:{5},�ʲ��˻�:{6},ί������:{7},�˻����:{8},"+
                "���װ��:{9},ί��״̬:{10},֤ȯҵ��:{11},ҵ����Ϊ:{12},ί������:{13},ί�����:{14},�ڲ�����:{15},���׵�Ԫ:{16},ί�м۸�:{17},"+
                "ί������:{18},֤ȯ�˻��ӱ���:{19},��Ȩ��Լ�˻�:{20},��Լ����:{21},��Լ���:{22},���Ҵ���:{23},���֤ȯ���:{24},���֤ȯ����:{25},���֤ȯ����:{26}",
                ((char)Stkex).ToString(), StkCode, OrderId, Trdacct, ((char)IsWithdraw).ToString(), CustCode, CuacctCode, OrderBsn, CuacctSn,
                Stkbd, ((char)OrderStatus).ToString(), StkBiz, StkBizAction, OrderDate, OrderSn, IntOrg, Stkpbu, OrderPrice,
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
}