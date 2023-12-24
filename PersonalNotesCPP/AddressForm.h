#pragma once
#include "BaseDBHelper.h"
#include "Models.h"


namespace CppCLRWinFormsProject {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class AddressForm : public System::Windows::Forms::Form
	{
	public:
		AddressForm(long id, CppCLRWinFormsProject::DBHelper^ helper)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
			m_helper = helper;
			m_id = id;
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~AddressForm()
		{
			if (components)
			{
				delete components;
			}
		}	private: System::Windows::Forms::DateTimePicker^ birth_dateTimePicker;
	protected:
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::Button^ Cancel_Button;
	private: System::Windows::Forms::Button^ OK_Button;
	private: System::Windows::Forms::TextBox^ notesTextBox;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::TextBox^ addressTextBox;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::MaskedTextBox^ phoneTextBox;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ nameTextBox;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::MaskedTextBox^ birth_dateMaskedTextBox;

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(AddressForm::typeid));
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->Cancel_Button = (gcnew System::Windows::Forms::Button());
			this->OK_Button = (gcnew System::Windows::Forms::Button());
			this->notesTextBox = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->addressTextBox = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->phoneTextBox = (gcnew System::Windows::Forms::MaskedTextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->nameTextBox = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->birth_dateMaskedTextBox = (gcnew System::Windows::Forms::MaskedTextBox());
			this->SuspendLayout();
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(349, 9);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(86, 13);
			this->label5->TabIndex = 22;
			this->label5->Text = L"Дата рождения";
			// 
			// Cancel_Button
			// 
			this->Cancel_Button->DialogResult = System::Windows::Forms::DialogResult::Cancel;
			this->Cancel_Button->Location = System::Drawing::Point(609, 102);
			this->Cancel_Button->Name = L"Cancel_Button";
			this->Cancel_Button->Size = System::Drawing::Size(64, 64);
			this->Cancel_Button->TabIndex = 21;
			this->Cancel_Button->UseVisualStyleBackColor = true;
			this->Cancel_Button->Click += gcnew System::EventHandler(this, &AddressForm::Cancel_Button_Click);
			// 
			// OK_Button
			// 
			this->OK_Button->DialogResult = System::Windows::Forms::DialogResult::OK;
			this->OK_Button->Location = System::Drawing::Point(609, 5);
			this->OK_Button->Name = L"OK_Button";
			this->OK_Button->Size = System::Drawing::Size(64, 64);
			this->OK_Button->TabIndex = 20;
			this->OK_Button->UseVisualStyleBackColor = true;
			this->OK_Button->Click += gcnew System::EventHandler(this, &AddressForm::OK_Button_Click);
			// 
			// notesTextBox
			// 
			this->notesTextBox->Location = System::Drawing::Point(98, 126);
			this->notesTextBox->Multiline = true;
			this->notesTextBox->Name = L"notesTextBox";
			this->notesTextBox->Size = System::Drawing::Size(458, 147);
			this->notesTextBox->TabIndex = 19;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(12, 126);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(80, 13);
			this->label4->TabIndex = 18;
			this->label4->Text = L"Комментарии:";
			// 
			// addressTextBox
			// 
			this->addressTextBox->Location = System::Drawing::Point(64, 82);
			this->addressTextBox->Name = L"addressTextBox";
			this->addressTextBox->Size = System::Drawing::Size(493, 20);
			this->addressTextBox->TabIndex = 17;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(12, 85);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(41, 13);
			this->label3->TabIndex = 16;
			this->label3->Text = L"Адрес:";
			// 
			// phoneTextBox
			// 
			this->phoneTextBox->Location = System::Drawing::Point(64, 42);
			this->phoneTextBox->Mask = L"+7 (999) 999-99-99";
			this->phoneTextBox->Name = L"phoneTextBox";
			this->phoneTextBox->Size = System::Drawing::Size(133, 20);
			this->phoneTextBox->TabIndex = 15;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(12, 50);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(29, 13);
			this->label2->TabIndex = 14;
			this->label2->Text = L"Тел.";
			// 
			// nameTextBox
			// 
			this->nameTextBox->Location = System::Drawing::Point(64, 7);
			this->nameTextBox->Name = L"nameTextBox";
			this->nameTextBox->Size = System::Drawing::Size(263, 20);
			this->nameTextBox->TabIndex = 13;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(9, 7);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(37, 13);
			this->label1->TabIndex = 12;
			this->label1->Text = L"ФИО:";
			// 
			// birth_dateMaskedTextBox
			// 
			this->birth_dateMaskedTextBox->Location = System::Drawing::Point(442, 9);
			this->birth_dateMaskedTextBox->Mask = L"00.00.0000";
			this->birth_dateMaskedTextBox->Name = L"birth_dateMaskedTextBox";
			this->birth_dateMaskedTextBox->Size = System::Drawing::Size(114, 20);
			this->birth_dateMaskedTextBox->TabIndex = 23;
			// 
			// AddressForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(688, 294);
			this->Controls->Add(this->birth_dateMaskedTextBox);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->Cancel_Button);
			this->Controls->Add(this->OK_Button);
			this->Controls->Add(this->notesTextBox);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->addressTextBox);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->phoneTextBox);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->nameTextBox);
			this->Controls->Add(this->label1);
			//this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"AddressForm";
			this->Load += gcnew System::EventHandler(this, &AddressForm::OnLoad);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private:
		CppCLRWinFormsProject::DBHelper^ m_helper;
		AddressBook^ m_record;
		long m_id;
		System::Void OnLoad(System::Object^ sender, System::EventArgs^ e)
		{
			String^ progExe = L"PersonalNotesCPP.exe";
			String^ documentsPath = System::Environment::GetCommandLineArgs()[0];
			
			if (m_id > 0)
			{
				m_record = m_helper->GetAddressDataRecord(m_id);
				if (m_record != nullptr)
				{
					nameTextBox->Text = m_record->name;
					birth_dateMaskedTextBox->Text = m_record->birth_date->ToString("dd.MM.yyyy");
					phoneTextBox->Text = m_record->phone;
					addressTextBox->Text = m_record->address;
					notesTextBox->Text = m_record->comments;

				}
			}

			String^ fname = L"Images\\OK48.png";
			String^ path = documentsPath->Replace(progExe, fname);
			OK_Button->Image = Image::FromFile(path);

			fname = L"Images\\cancel48.png";
			path = documentsPath->Replace(progExe, fname);
			Cancel_Button->Image = Image::FromFile(path);

			//fname = L"Images\\note32.ico";
			//path = documentsPath->Replace(progExe, fname);
			//Icon = Icon::ExtractAssociatedIcon(path);

		}

	private: System::Void OK_Button_Click(System::Object^ sender, System::EventArgs^ e) {
		if (m_id > 0) // update
		{
			if (m_record != nullptr)
			{
				m_record->id = m_id;
				m_record->name = nameTextBox->Text;
				m_record->birth_date = DateTime::Parse(birth_dateMaskedTextBox->Text);
				m_record->phone = phoneTextBox->Text;
				m_record->address = addressTextBox->Text;
				m_record->comments = notesTextBox->Text;

				int recs = m_helper->UpdateAdressRecord(m_record);
				if (recs < 1)
				{
					MessageBox::Show(m_helper->getErrorText(), L"Неудача изменения записи");
					m_record = nullptr;
					DialogResult = System::Windows::Forms::DialogResult::Cancel;
					return;
				}
				else
					DialogResult = System::Windows::Forms::DialogResult::OK;
			}
		}
		else // insert
		{
			m_record = gcnew AddressBook;
			m_record->id = 0;
			m_record->name = nameTextBox->Text;
			m_record->birth_date = DateTime::Parse(birth_dateMaskedTextBox->Text);
			m_record->phone = phoneTextBox->Text;
			m_record->address = addressTextBox->Text;
			m_record->comments = notesTextBox->Text;
			int recs = m_helper->AddAddressRecord(m_record);
			if (recs < 1)
			{
				MessageBox::Show(m_helper->getErrorText(), L"Неудача добавления записи записи");
				m_record = nullptr;
				DialogResult = System::Windows::Forms::DialogResult::Cancel;
				return;
			}
			else
				DialogResult = System::Windows::Forms::DialogResult::OK;

		}


	}
private: System::Void Cancel_Button_Click(System::Object^ sender, System::EventArgs^ e) {
}

};
}
