#pragma once
#include "BaseDBHelper.h"

namespace CppCLRWinFormsProject {
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	ref class NoteForm : public System::Windows::Forms::Form
	{
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Button^ Cancel_Button;
	private: System::Windows::Forms::Button^ OK_Button;

	private: System::Windows::Forms::TextBox^ notesTextBox;
	private: System::Windows::Forms::MaskedTextBox^ dateMaskedTextBox;

	private: System::Windows::Forms::Label^ label1;
	public:
		NoteForm(long id, CppCLRWinFormsProject::DBHelper^ helper)
		{
			this->InitializeComponent();
			m_helper = helper;
			m_id = id;
		}
		~NoteForm()
		{

		}

	private: System::Void InitializeComponent() {
		this->label4 = (gcnew System::Windows::Forms::Label());
		this->Cancel_Button = (gcnew System::Windows::Forms::Button());
		this->OK_Button = (gcnew System::Windows::Forms::Button());
		this->label1 = (gcnew System::Windows::Forms::Label());
		this->notesTextBox = (gcnew System::Windows::Forms::TextBox());
		this->dateMaskedTextBox = (gcnew System::Windows::Forms::MaskedTextBox());
		this->SuspendLayout();
		// 
		// label4
		// 
		this->label4->AutoSize = true;
		this->label4->Location = System::Drawing::Point(13, 64);
		this->label4->Name = L"label4";
		this->label4->Size = System::Drawing::Size(54, 13);
		this->label4->TabIndex = 17;
		this->label4->Text = L"Заметки:";
		// 
		// Cancel_Button
		// 
		this->Cancel_Button->DialogResult = System::Windows::Forms::DialogResult::Cancel;
		this->Cancel_Button->Location = System::Drawing::Point(586, 116);
		this->Cancel_Button->Name = L"Cancel_Button";
		this->Cancel_Button->Size = System::Drawing::Size(64, 64);
		this->Cancel_Button->TabIndex = 16;
		this->Cancel_Button->UseVisualStyleBackColor = true;
		// 
		// OK_Button
		// 
		this->OK_Button->DialogResult = System::Windows::Forms::DialogResult::OK;
		this->OK_Button->Location = System::Drawing::Point(586, 19);
		this->OK_Button->Name = L"OK_Button";
		this->OK_Button->Size = System::Drawing::Size(64, 64);
		this->OK_Button->TabIndex = 15;
		this->OK_Button->UseVisualStyleBackColor = true;
		this->OK_Button->Click += gcnew System::EventHandler(this, &NoteForm::OK_Button_Click);
		// 
		// label1
		// 
		this->label1->AutoSize = true;
		this->label1->Location = System::Drawing::Point(14, 13);
		this->label1->Name = L"label1";
		this->label1->Size = System::Drawing::Size(80, 13);
		this->label1->TabIndex = 13;
		this->label1->Text = L"Дата и время:";
		// 
		// notesTextBox
		// 
		this->notesTextBox->Location = System::Drawing::Point(101, 64);
		this->notesTextBox->Multiline = true;
		this->notesTextBox->Name = L"notesTextBox";
		this->notesTextBox->ScrollBars = System::Windows::Forms::ScrollBars::Both;
		this->notesTextBox->Size = System::Drawing::Size(458, 204);
		this->notesTextBox->TabIndex = 18;
		// 
		// dateMaskedTextBox
		// 
		this->dateMaskedTextBox->Location = System::Drawing::Point(101, 13);
		this->dateMaskedTextBox->Mask = L"00.00.0000";
		this->dateMaskedTextBox->Name = L"dateMaskedTextBox";
		this->dateMaskedTextBox->Size = System::Drawing::Size(140, 20);
		this->dateMaskedTextBox->TabIndex = 19;
		// 
		// NoteForm
		// 
		this->ClientSize = System::Drawing::Size(664, 285);
		this->Controls->Add(this->dateMaskedTextBox);
		this->Controls->Add(this->notesTextBox);
		this->Controls->Add(this->label4);
		this->Controls->Add(this->Cancel_Button);
		this->Controls->Add(this->OK_Button);
		this->Controls->Add(this->label1);
		this->MaximizeBox = false;
		this->Name = L"NoteForm";
		this->Text = L"Заметка";
		this->Load += gcnew System::EventHandler(this, &NoteForm::OnLoad);
		this->ResumeLayout(false);
		this->PerformLayout();

	}
	private: 
		CppCLRWinFormsProject::DBHelper^ m_helper;
		Note^ m_note;
		long m_id;

		System::Void OnLoad(System::Object^ sender, System::EventArgs^ e) {
		String^ progExe = L"PersonalNotesCPP.exe";
		String^ documentsPath = System::Environment::GetCommandLineArgs()[0];

		if (m_id > 0)
		{
			m_note =m_helper->GetNotesDataRecord(m_id);
			if (m_note != nullptr)
			{
				dateMaskedTextBox->Text = m_note->note_datetime->ToString("dd.MM.yyyy");
				notesTextBox->Text = m_note->comments;
			}
		}

		String^ fname = L"Images\\OK48.png";
		String^ path = documentsPath->Replace(progExe, fname);
		OK_Button->Image = Image::FromFile(path);

		fname = L"Images\\cancel48.png";
		path = documentsPath->Replace(progExe, fname);
		Cancel_Button->Image = Image::FromFile(path);


	}
	private: System::Void OK_Button_Click(System::Object^ sender, System::EventArgs^ e) {
		if (m_id > 0)
		{
			if (m_note != nullptr)
			{
				m_note->id = m_id;
				m_note->note_datetime = DateTime::Parse(dateMaskedTextBox->Text);
				m_note->comments = notesTextBox->Text;

				int recs = m_helper->UpdateNotesRecord(m_note);
				if (recs < 1)
				{
					MessageBox::Show(m_helper->getErrorText(), L"Ошибка изменения записи");
					DialogResult = System::Windows::Forms::DialogResult::Cancel;
				}
				else
					DialogResult = System::Windows::Forms::DialogResult::OK;

			}
		}
		else
		{
			m_note = gcnew Note;
			
			m_note->id = 0;
			m_note->note_datetime = DateTime::Parse(dateMaskedTextBox->Text);
			m_note->comments = notesTextBox->Text;
			
			int recs = m_helper->AddNoteRecord(m_note);
			if (recs < 1)
			{
				MessageBox::Show(m_helper->getErrorText(), L"Ошибка добавления записи");
				DialogResult = System::Windows::Forms::DialogResult::Cancel;
			}
			else
				DialogResult = System::Windows::Forms::DialogResult::OK;

		}

	}
};
}

