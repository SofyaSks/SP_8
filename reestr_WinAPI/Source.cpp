//#include<iostream>
//#include "Windows.h"
//using namespace std;
//
//
//int main() {
//	HKEY hkey;
//
//	LONG result = RegOpenKeyEx(HKEY_CURRENT_USER,
//		TEXT("Software\\Something\\Program"),
//		0,
//		KEY_ALL_ACCESS,
//		&hkey);
//
//	if (result != ERROR_SUCCESS)
//		throw runtime_error("RegOpenKeyEx failed");
//
//	DWORD runs = 30;
//	LONG result = RegSetValueEx(hkey,
//		TEXT("RUNS"),
//		0,
//		REG_DWORD,
//		(const BYTE*)&runs,
//		sizeof(runs));
//		
//	DWORD type, runs, size;
//	LONG result2 = RegGetValue(HKEY_CURRENT_USER,
//		TEXT("Software\\Something\\Program"),
//		TEXT("Runs"),
//		RRF_RT_DWORD,
//		&type, &runs, &size);
//
//	return 0;
//}