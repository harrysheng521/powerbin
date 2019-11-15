#if !defined(__kbss_encrypt_h__)
#define __kbss_encrypt_h__

#if !defined(KBSS_ENCRYPT) && !defined(KBSS_DECRYPT)
#define KBSS_ENCRYPT
#undef KBSS_DECRYPT
#endif

#define KBSS_COMENCRYPT
#define KBSS_COMDECRYPT

#if defined(OS_IS_WINDOWS)

#ifdef  DLLEXPORTS
#define DLLEXPORT _declspec(dllexport)
#else
#define DLLEXPORT _declspec(dllimport)
#endif
#define KBSS_CALLTYPE _cdecl
#else
#define DLLEXPORT
#define KBSS_CALLTYPE
#endif

#if defined (_MSC_VER) && (_MSC_VER == 1200)
  #if defined(WIN32)
  typedef __int64 LONGLONG;
  #elif defined(WIN64)
  typedef long long LONGLONG;
  #endif
#else
  typedef long long LONGLONG;
#endif

#ifdef __cplusplus
extern "C"
{
#endif

//------------------------------------------------------------------------------
// �������ƣ�kbss_encrypt
// �������������ݴ洢�����㷨
// ����˵����p_pszOutput      [out]    ����
//           p_iFixedSize     [in]     ���Ļ�������С
//           p_pszInput       [int]    ����
//           p_pszKey         [in]     ��Կ
// ����˵����(��)
// ������ע��
#if defined(KBSS_ENCRYPT)
void DLLEXPORT KBSS_CALLTYPE kbss_encrypt(char *p_pszOutput, int p_iFixedSize, const char *p_pszInput, const char *p_pszKey);
#endif

//------------------------------------------------------------------------------
// �������ƣ�kbss_decrypt
// �������������ݴ洢�����㷨
// ����˵����p_pszOutput      [out]    ����
//           p_iFixedSize     [in]     ���Ļ�������С
//           p_pszInput       [int]    ����
//           p_pszKey         [in]     ��Կ
// ����˵����(��)
// ������ע���˺����������ṩ.
#if defined(KBSS_DECRYPT)
void DLLEXPORT KBSS_CALLTYPE kbss_decrypt(char *p_pszOutput, int p_iFixedSize, const char *p_pszInput, const char *p_pszKey);
#endif


//------------------------------------------------------------------------------
// �������ƣ�kbss_recrypt
// �������������ݴ洢�ؼ����㷨
// ����˵����p_pszOutput      [out]    ����(������)
//           p_iFixedSize     [in]     ����(������)��������С
//           p_pszInput       [int]    ����(����ǰ)
//           p_pszOldKey      [in]     ԭ��Կ
//           p_pszNewKey      [in]     ����Կ
// ����˵����(��)
// ������ע���˺������ڸ������ܵ���Կ
#if defined(KBSS_ENCRYPT)
void DLLEXPORT KBSS_CALLTYPE kbss_recrypt(char *p_pszOutput, int p_iFixedSize, const char *p_pszInput, const char *p_pszOldKey, const char *p_pszNewKey);
#endif

//------------------------------------------------------------------------------
// �������ƣ�kbss_encrypt1
// �������������ݴ洢�����㷨
// ����˵����p_pszOutput      [out]    ����
//           p_iFixedSize     [in]     ���Ļ�������С
//           p_pszInput       [int]    ����
//           p_pszKey         [in]     ��Կ
//           p_nEncodeType    [in]     �����㷨 0:KBSS��׼�㷨
//                                              1:��֤W�漯�н����㷨
//                                              2:��֤U�漯�н����㷨
// ����˵����0 ��ʾ�ɹ� ������ʾʧ��
// ������ע��
#if defined(KBSS_ENCRYPT)
int DLLEXPORT KBSS_CALLTYPE kbss_encrypt1(char *p_pszOutput,
                                           int p_iFixedSize,
                                           const char *p_pszInput,
                                           const char *p_pszKey,
                                           int p_nEncodeType);
#endif

//------------------------------------------------------------------------------
// �������ƣ�kbss_decrypt1
// �������������ݴ洢�����㷨
// ����˵����p_pszOutput      [out]    ����
//           p_iFixedSize     [in]     ���Ļ�������С
//           p_pszInput       [int]    ����
//           p_pszKey         [in]     ��Կ
//           p_nEncodeType    [in]     �����㷨 0:KBSS��׼�㷨
//                                              1:��֤W�漯�н����㷨
//                                              2:��֤U�漯�н����㷨
// ����˵����0 ��ʾ�ɹ� ������ʾʧ��
// ������ע���˺����������ṩ.
#if defined(KBSS_DECRYPT)
int DLLEXPORT KBSS_CALLTYPE kbss_decrypt1(char *p_pszOutput,
                                          int p_iFixedSize,
                                          const char *p_pszInput,
                                          const char *p_pszKey,
                                          int p_nEncodeType);
#endif


//------------------------------------------------------------------------------
// �������ƣ�kbss_recrypt
// �������������ݴ洢�ؼ����㷨
// ����˵����p_pszOutput      [out]    ����(������)
//           p_iFixedSize     [in]     ����(������)��������С
//           p_pszInput       [int]    ����(����ǰ)
//           p_pszOldKey      [in]     ԭ��Կ
//           p_pszNewKey      [in]     ����Կ
//           p_nEncodeType    [in]     �����㷨 0:KBSS��׼�㷨
//                                              1:��֤W�漯�н����㷨
//                                              2:��֤U�漯�н����㷨
// ����˵����0 ��ʾ�ɹ� ������ʾʧ��
// ������ע���˺������ڸ������ܵ���Կ
#if defined(KBSS_ENCRYPT)
int DLLEXPORT KBSS_CALLTYPE kbss_recrypt1(char *p_pszOutput,
                                          int p_iFixedSize,
                                          const char *p_pszInput,
                                          const char *p_pszOldKey,
                                          const char *p_pszNewKey,
                                          int p_nEncodeType);
#endif

//------------------------------------------------------------------------------
// �������ƣ�kbss_comencrypt
// ����������ͨ�ż����㷨
// ����˵����p_pszOutput      [out]    ����,��С��С��1024
//           p_pszInput       [int]    ����,��С��С��1024
//           p_pszKey         [in]     ��Կ,��С������224
// ����˵����(��)
// ������ע������ͨ�Ź����йؼ���Ϣ�ļ���
#if defined(KBSS_COMENCRYPT)
void DLLEXPORT KBSS_CALLTYPE kbss_comencrypt(char *p_pszOutput, const char *p_pszInput, const char *p_pszKey);
#endif

//------------------------------------------------------------------------------
// �������ƣ�kbss_comdecrypt
// ����������ͨ�ż����㷨
// ����˵����p_pszOutput      [out]    ����,��С��С��1024
//           p_pszInput       [int]    ����,��С��С��1024
//           p_pszKey         [in]     ��Կ,��С������224
// ����˵����(��)
// ������ע������ͨ�Ź����йؼ���Ϣ�Ľ���
#if defined(KBSS_COMDECRYPT)
void DLLEXPORT KBSS_CALLTYPE kbss_comdecrypt(char *p_pszOutput, const char *p_pszInput, const char *p_pszKey);
#endif


//------------------------------------------------------------------------------
// �������ƣ�AES_Encrypt1
// ����������AES�����㷨
// ����˵����p_pszEncrResult  [out]    ����
//           p_iSize          [int]    ���Ļ�������С
//           p_llKey          [in]     ��Կ�����û�����
//           p_pszEncrInfo    [in]     ����
// ����˵����(��)
// ������ע��ǰ��̨�ӽ�����֤����ʱ��
void DLLEXPORT KBSS_CALLTYPE AES_Encrypt1(char *p_pszEncrResult, int p_iSize, LONGLONG p_llKey, const char * p_pszEncrInfo);

//------------------------------------------------------------------------------
// �������ƣ�AES_Decrypt1
// ����������AES�����㷨
// ����˵����p_pszDecrResult  [out]    ����
//           p_iSize          [int]    ���Ļ�������С
//           p_llKey          [in]     ��Կ�����û�����
//           p_pszDecrInfo    [in]     ����
// ����˵����(��)
// ������ע��ǰ��̨�ӽ�����֤����ʱ��
void DLLEXPORT KBSS_CALLTYPE AES_Decrypt1(char *p_pszDecrResult, int p_iSize, LONGLONG p_llKey, const char * p_pszDecrInfo);


//------------------------------------------------------------------------------
// �������ƣ�MD5_Digist
// ����������MD5����ժҪ�㷨
// ����˵����p_pszDigResult   [out]    ����
//           p_iSize          [int]    ���Ļ�������С
//           p_pszDigRetInt   [in]     ժҪ
//           p_pszDigInfo     [in]     ��Ϣ��
// ����˵����(��)
// ������ע�����㷨�����棬����ͨ�Ź�������Ϣ�ķ��۸�
void DLLEXPORT KBSS_CALLTYPE MD5_Digist(char * p_pszDigResult, int p_iSize, unsigned char p_pszDigRetInt[16], unsigned char * p_pszDigInfo);


//------------------------------------------------------------------------------
// �������ƣ�Base64_Encode
// ����������Base64�����㷨
// ����˵����p_pszEnResult    [out]    ����
//           p_pszEnInfo      [in]     ����
//           p_iSize          [in]     ���ĳ���
// ����˵����(��)
// ������ע�����㷨����ͨ�Ź����еĲ��ɼ��ַ���ת����
void DLLEXPORT KBSS_CALLTYPE Base64_Encode(char * p_pszEnResult, const unsigned char * p_pszEnInfo, int p_iSize);

//------------------------------------------------------------------------------
// �������ƣ�Base64_Decode
// ����������Base64�����㷨
// ����˵����p_pszResult      [out]    ����
//           p_refiCount      [out]    ���ĳ���
//           pszDeInfo        [in]     ����
// ����˵����(��)
// ������ע�����㷨����ͨ�Ź����еĲ��ɼ��ַ���ת����
void DLLEXPORT KBSS_CALLTYPE Base64_Decode(unsigned char *p_pszResult, int & p_refiCount, const char * pszDeInfo);


//------------------------------------------------------------------------------
// �������ƣ�RC5_Encrypt1
// ����������RC5�����㷨
// ����˵����p_pszEnResult    [out]    ����
//           p_iSize          [in]     ���Ļ�������С
//           p_llKey          [in]     ��Կ�����û�����
//           p_pszEnInfo      [in]     ����
// ����˵����(��)
// ������ע�����㷨����ǰ��̨�ӽ��ܱ��ܼ�(��֤��)��
void DLLEXPORT KBSS_CALLTYPE RC5_Encrypt1(char * p_pszEnResult, int p_iSize, LONGLONG p_llKey, const char * p_pszEnInfo);

//------------------------------------------------------------------------------
// �������ƣ�RC5_Decrypt1
// ����������RC5�����㷨
// ����˵����p_pszDeResult    [out]    ����
//           p_iSize          [in]     ���Ļ�������С
//           p_llKey          [in]     ��Կ�����û�����
//           p_pszDeInfo      [in]     ����
// ����˵����(��)
// ������ע�����㷨����ǰ��̨�ӽ��ܱ��ܼ�(��֤��)��
void DLLEXPORT KBSS_CALLTYPE RC5_Decrypt1(char * p_pszDeResult, int p_iSize, LONGLONG p_llKey, const char * p_pszDeInfo);


// iEncryptType = 1 �������˼ӽ���Key2����ʱ�����pszKey��iKeySizeû�����ã��ڲ�д������Կ��
// iEncryptType = 2 ��������ӽ���
void DLLEXPORT KBSS_CALLTYPE RC5_Encrypt(char * p_pszEnResult, int p_iSize, const unsigned char * p_pszKey, int p_iKeySize, int p_iEncryptType, const char * p_pszEnInfo);
void DLLEXPORT KBSS_CALLTYPE RC5_Decrypt(char * p_pszDeResult, int p_iSize, const unsigned char * p_pszKey, int p_iKeySize, int p_iDecryptType, const char * p_pszDeInfo);

//------------------------------------------------------------------------------
// �������ƣ�RSA_GenRsaKey
// ����������RSA��Կ�����㷨
// ����˵����p_pszPublicKey   [out]    ��Կ
//           p_iPublicKeySize [in]     ��Կ��������С
//           p_pszPrivateKey  [out]    ˽Կ
//           p_iPrivateKeySize[in]     ˽Կ��������С
//           p_iKeySize       [in]     ��Կǿ��:256bit
// ����˵����int
// ������ע�����㷨���ڲ���RSA�Ĺ�˽Կ
int DLLEXPORT KBSS_CALLTYPE RSA_GenRsaKey(char *p_pszPublicKey, int p_iPublicKeySize, char *p_pszPrivateKey, int p_iPrivateKeySize, int p_iKeySize = 256);



//----------------------------------------------------------------------------
// ǩ������:RSA_Encrypt\RSA_Decrypt
// ���麯��Ϊ����ǩ��:����˽Կ����,��Կ���н���
//------------------------------------------------------------------------------
// �������ƣ�RSA_Encrypt
// ����������RSAǩ�������㷨
// ����˵����p_pszSignResult  [out]    ����
//           p_iSize          [in]     ���Ļ�������С
//           p_pszKey         [in]     ˽Կ
//           p_pszSignInfo    [in]     ����
//           p_iLen           [in]     ���ĳ���
// ����˵����int
// ������ע�����㷨��������ǩ��
int DLLEXPORT KBSS_CALLTYPE RSA_Encrypt(char *p_pszSignResult, int p_iSize, char * p_pszKey, const unsigned char *p_pszSignInfo, int p_iLen);

//------------------------------------------------------------------------------
// �������ƣ�RSA_Decrypt
// ����������RSAǩ�������㷨
// ����˵����p_pszSignResult [out]     ����
//           p_iSize         [in]      ���Ļ�������С
//           p_refiCount     [out]     ������Ч����
//           p_pszKey        [in]      ��Կ
//           p_pszVerifyInfo [in]      ����
// ����˵����int
// ������ע�����㷨��������ǩ��
int DLLEXPORT KBSS_CALLTYPE RSA_Decrypt(char *p_pszDecrResult, int p_iSize, int &p_refiCount, const char *p_pszKey, const char *p_pszVerifyInfo);

//----------------------------------------------------------------------------
// RSA����:RSA_Encrypt1\RSA_Decrypt1
// ���麯��Ϊ����ǩ��:���ù�Կ����,˽Կ���н���
//------------------------------------------------------------------------------
// �������ƣ�RSA_Encrypt1
// ����������RSA�����㷨
// ����˵����p_pszSignResult [out]     ����
//           p_iSize         [in]      ���Ļ�������С
//           p_pszKey        [in]      ��Կ
//           p_pszSignInfo   [in]      ����
//           p_iLen          [in]      ���ĳ���
// ����˵����int
// ������ע�����㷨�������ݼ���
int DLLEXPORT KBSS_CALLTYPE RSA_Encrypt1(char *p_pszSignResult, int p_iSize, char * p_pszKey, const unsigned char *p_pszSignInfo, int p_iLen);


//------------------------------------------------------------------------------
// �������ƣ�RSA_Decrypt1
// ����������RSA�����㷨
// ����˵����p_pszSignResult [out]     ����
//           p_iSize         [in]      ���Ļ�������С
//           p_pszKey        [in]      ˽Կ
//           p_pszVerifyInfo [in]      ����
// ����˵����int
// ������ע�����㷨�������ݽ���
int DLLEXPORT KBSS_CALLTYPE RSA_Decrypt1(char *p_pszDecrResult, int p_iSize, int &p_refiCount, const char *p_pszKey, const char *p_pszVerifyInfo);

//------------------------------------------------------------------------------
// �������ƣ�RandomNo
// ���������������
// ����˵����p_pszRandNoBuf  [out]     ������
//           p_iSize         [in]      ��������С
// ����˵����void
void DLLEXPORT KBSS_CALLTYPE RandomNo(char * p_pszRandNoBuf, int p_iSize);



//------------------------------------------------------------------------------
// ����������ͨѶ����(U��)
// ���˵����
//           p_lUserCode : �û�����
//           p_lpszPlainText : �������ģ������Ч���ܳ���Ϊ15λ��
//                             ȡֵ��Χ����'\0'����������15λ�������ڵ��ַ�����
//           p_lpszCipherText : �������ģ�ָ����ָ�Ŀռ��С������ڵ�33���ֽڡ�
void DLLEXPORT KBSS_CALLTYPE UF_CommEncrypt(long p_lUserCode, const char * p_lpszPlainText, char * p_lpszCipherText);

//------------------------------------------------------------------------------
// ����������ͨѶ����(U��)
// ���˵����
//           p_lUserCode : �û�����
//           p_lpszCipherText : �������ģ���'\0'������32���ֽڵ��ַ�����
//           p_lpszPlainText : �������ģ�ָ����ָ�Ŀռ��С������ڵ�17���ֽڡ�
void DLLEXPORT KBSS_CALLTYPE UF_CommDecrypt(long p_lUserCode, const char * p_lpszCipherText, char * p_lpszPlainText);

//------------------------------------------------------------------------------
// ����������
//     OEMУ��
// ����˵����
//   p_pszOemName      ��������
//   p_pszOemCode      OEM����
//   p_pszOemBzxx      OEM��ע��Ϣ
//   p_pszZqszwmc      ȯ����������
//   p_iTrdDate        ��ǰ��������
//   p_refiValidDate   ʧЧ����
//   p_iPinCode        PIN���룬ȱʡΪ6892
// ����˵����
//   < 0 У�鲻ͨ��
//   -1  OEM�����볧�����Ʋ���
//   -2  OEM�Ƿ��������֤��˾��ʵ!(oldcrypt)
//   -3  OEM�Ƿ��������֤��˾��ʵ!(newcrypt)
//   -4  ��ע��Ϣ����,����ӦΪ16/32λ
//   >=0  У��ͨ��, ����ֵΪ������Ч����
int DLLEXPORT KBSS_CALLTYPE kbss_checkoem(unsigned char *p_pszOemName,
             char *p_pszOemCode,
             char *p_pszOemBzxx,
             char *p_pszZqszwmc,
             int p_iTrdDate,
             int &p_refiValidDate,
             int p_iPinCode = 6892);

#ifdef __cplusplus
}
#endif

#endif  // __kbss_encrypt_h__
