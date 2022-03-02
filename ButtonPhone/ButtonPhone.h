
// ButtonPhone.h: главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить pch.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы


// CButtonPhoneApp:
// Сведения о реализации этого класса: ButtonPhone.cpp
//

class CButtonPhoneApp : public CWinApp
{
public:
	CButtonPhoneApp();

// Переопределение
public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern CButtonPhoneApp theApp;
