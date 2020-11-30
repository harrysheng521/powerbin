#ifndef  _AUTHENTICATIONCLIENT_H
#define  _AUTHENTICATIONCLIENT_H
 
typedef  int (__stdcall * pfnRequestResult)(HANDLE handle, char * szProgram, char *inputParam,char *outputResult);                        
#define CLIENT_COM_DLL_LOAD_FAILED 100109    //�ͻ���ͨѶ��̬�� ����ʧ�� comclient.dll
#define CLIENT_COM_DLL_FUNC_FAILED 100110    //��̬���ȡ������ڵ�ַʧ��

#ifdef AUTHCLIENT_EXPORTS
#define AUTHCLIENTAPI __declspec(dllexport)
#else
#define AUTHCLIENTAPI __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" { 
#endif

	
//------------------------------------------------------------------------------
// �������ƣ�UserLogin
// �����������û���½ ���У��
// ���˵���� 
//      [in]  p_hHandle         ����ͨѶ�ľ��
//      [in]  p_pszInputParam   �����̨�Ĳ���������֮�䶺��","�ָ�����������ֵ��ð��":"�ָ��� ��ʽ��F_OP_USER:8888,F_OP_ROLE:2,F_OP_SITE:234233,
//      [out] p_pszOutputResult  ��̨���������صĴ�����������p_pszOutputResult�Ŀռ��СҪ�����2048�ֽڡ�
// ����˵����
//       ���� 0, �����ɹ����ء����󣬷��ش�����롣
AUTHCLIENTAPI int __stdcall UserLogin(HANDLE p_hHandle, char *inputParam, char *outputResult);


//------------------------------------------------------------------------------
// �������ƣ�UserLogout
// �����������û��ǳ�,ɾ��ƾ֤��
// ���˵����   
//      [in]  p_lHandle         ����ͨѶ�ľ��
//      [in]  p_pszInputParam   �����̨�Ĳ���������֮�䶺��","�ָ�����������ֵ��ð��":"�ָ��� ��ʽ��F_OP_USER:8888,F_OP_ROLE:2,F_OP_SITE:234233,
//      [out] p_pszOutputResult  ��̨���������صĴ�����������p_pszOutputResult�Ŀռ��СҪ�����2048�ֽڡ�
// ����˵����
//      ���� 0, �����ɹ����ء����󣬷��ش�����롣
AUTHCLIENTAPI int __stdcall UserLogout(HANDLE p_hHandle, char *inputParam, char *outputResult);


//------------------------------------------------------------------------------
// �������ƣ�CheckUserAuthInfo
// �����������û�������֤��ҵ����֤��
// ���˵���� 
//      [in]  p_lHandle         ����ͨѶ�ľ��
//      [in]  p_pszInputParam   �����̨�Ĳ���������֮�䶺��","�ָ�����������ֵ��ð��":"�ָ��� ��ʽ��F_OP_USER:8888,F_OP_ROLE:2,F_OP_SITE:234233,
//      [out] p_pszOutputResult  ��̨���������صĴ�����������p_pszOutputResult�Ŀռ��СҪ�����2048�ֽڡ�
// ����˵����
//      ���� 0, �����ɹ����ء����󣬷��ش�����롣
AUTHCLIENTAPI int __stdcall CheckUserAuthInfo(HANDLE p_hHandle,char *inputParam,char *outputResult);



//------------------------------------------------------------------------------
// �������ƣ�CheckUserTicket
// ����������ƾ֤У��
// ���˵���� 
//      [in]  p_lHandle         ����ͨѶ�ľ��
//      [in]  p_pszInputParam   �����̨�Ĳ���������֮�䶺��","�ָ�����������ֵ��ð��":"�ָ��� ��ʽ��F_OP_USER:8888,F_OP_ROLE:2,F_OP_SITE:234233,
//      [out] p_pszOutputResult  ��̨���������صĴ�����������p_pszOutputResult�Ŀռ��СҪ�����2048�ֽڡ�
// ����˵����
//       ���� 0, �����ɹ����ء����󣬷��ش�����롣
AUTHCLIENTAPI int __stdcall CheckUserTicket(char *inputParam,char *outputResult);

//------------------------------------------------------------------------------
// �������ƣ�GetCARandCode
// ������������ȡ֤�������
// ���˵���� 
//      [in]  p_lHandle         ����ͨѶ�ľ��
//      [in]  p_pszInputParam   �����̨�Ĳ���������֮�䶺��","�ָ�����������ֵ��ð��":"�ָ��� ��ʽ��,
//      [out] p_pszUserCode     �û�����
//      [out] p_pszRandCode     ֤�������
// ����˵����
//      ���� 0, �����ɹ����ء����󣬷��ش�����롣
//                               -1 Ʊ��Ϊ��
AUTHCLIENTAPI int __stdcall GetCARandCode(HANDLE p_hHandle, char *p_pszInputParam, char * p_pszUserCode, char *p_pszRandCode);

//����һ������KESBCLI.dll ��ͨѶ���
AUTHCLIENTAPI int __stdcall Create_Auth_Handle(HANDLE &p_refhHandle);

//����һ������KESBCLI.dll ��ͨѶ���
AUTHCLIENTAPI int __stdcall Destroy_Auth_Handle(HANDLE &p_hHandle);
AUTHCLIENTAPI int __stdcall Test(void);

#ifdef __cplusplus
} 
#endif

#endif