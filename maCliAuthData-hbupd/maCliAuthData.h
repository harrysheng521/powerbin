
// maCliAuthData.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������
#include "maCliApi.h"

typedef struct
{
  char szCuacctCode[32];
  char szCuacctType[2];
  char szIntOrg[32];
  char szChannel[12];
  char szAuthData[128];
  char szAuthDataNew[128];
  char szUserCode[32];
  char szUserAuthData[128];
  char szThirdParty[1024];
  char szSessionId[129];
} ST_PARAM_USER;

typedef struct
{
	char szCustCode[32];
	char szCuacctCode[32];
	char szCurrency[2];
	char szTranType[2];
	char szTranAmt[22];
	char szFundPwd[33];
	char szBankCode[6];
	char szBankPwd[32];
	char szPwdFlag[2];
	char szTrdPwd[32];
	char szInitiator[2];
	char szExtOrg[6];
	char szTrdTermcode[20];
} ST_PARAM_FUND2STK;

typedef struct
{
	char szCuacctCode[32];
	char szCurrency[2];
	char szDirect[2];
	char szTranAmt[22];
} ST_PARAM_FUND_TRANS;

// CmaCliAuthDataApp:
// �йش����ʵ�֣������ maCliAuthData.cpp
//

class CMaCliAuthDataApp : public CWinApp
{
public:
  CMaCliAuthDataApp();
  ~CMaCliAuthDataApp();

public:
	virtual BOOL InitInstance();
  void GetParam(void);
  int ConnectCos(void);
  int AcctLogin(void);
  int AuthData(void);
  int FislBankStkTransfer(void);
  int FislFundTransfer(void);

public:
  ST_PARAM_USER m_stUser;
  ST_MACLI_CONNECT_OPTION m_stConn;
  MACLIHANDLE m_hHandle;
  ST_PARAM_FUND2STK m_stTranData;
  ST_PARAM_FUND_TRANS m_stFundTran;

	DECLARE_MESSAGE_MAP()
};

extern CMaCliAuthDataApp theApp;