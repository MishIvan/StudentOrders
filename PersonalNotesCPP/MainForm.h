#pragma once

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
	public ref class MainForm : public System::Windows::Forms::Form
	{
	public:
		MainForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MainForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TabControl^ MainTabControl;
	protected:
	private: System::Windows::Forms::TabPage^ addressTabPage;
	private: System::Windows::Forms::DataGridView^ addressDataGridView;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ id;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ name;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ phone;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ birth_date;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ address;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ comments;
	private: System::Windows::Forms::TabControl^ abcTabControl;
	private: System::Windows::Forms::TabPage^ tabPage1;
	private: System::Windows::Forms::TabPage^ tabPage2;
	private: System::Windows::Forms::TabPage^ tabPage3;
	private: System::Windows::Forms::TabPage^ tabPage4;
	private: System::Windows::Forms::TabPage^ tabPage5;
	private: System::Windows::Forms::TabPage^ tabPage6;
	private: System::Windows::Forms::TabPage^ tabPage7;
	private: System::Windows::Forms::TabPage^ tabPage8;
	private: System::Windows::Forms::TabPage^ tabPage9;
	private: System::Windows::Forms::TabPage^ tabPage10;
	private: System::Windows::Forms::TabPage^ tabPage11;
	private: System::Windows::Forms::TabPage^ tabPage12;
	private: System::Windows::Forms::TabPage^ tabPage13;
	private: System::Windows::Forms::TabPage^ tabPage14;
	private: System::Windows::Forms::TabPage^ tabPage15;
	private: System::Windows::Forms::TabPage^ tabPage16;
	private: System::Windows::Forms::TabPage^ tabPage17;
	private: System::Windows::Forms::TabPage^ tabPage18;
	private: System::Windows::Forms::TabPage^ tabPage19;
	private: System::Windows::Forms::TabPage^ tabPage20;
	private: System::Windows::Forms::TabPage^ tabPage21;
	private: System::Windows::Forms::TabPage^ tabPage22;
	private: System::Windows::Forms::TabPage^ tabPage23;
	private: System::Windows::Forms::TabPage^ tabPage24;
	private: System::Windows::Forms::TabPage^ tabPage25;
	private: System::Windows::Forms::TabPage^ notesTabPage;
	private: System::Windows::Forms::DataGridView^ notesDataGridView;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ id_notes;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ note_datetime;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ note;
	private: System::Windows::Forms::Button^ deleteButton;
	private: System::Windows::Forms::Button^ editButton;
	private: System::Windows::Forms::Button^ addButton;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle4 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle5 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle6 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MainForm::typeid));
			this->MainTabControl = (gcnew System::Windows::Forms::TabControl());
			this->addressTabPage = (gcnew System::Windows::Forms::TabPage());
			this->addressDataGridView = (gcnew System::Windows::Forms::DataGridView());
			this->id = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->name = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->phone = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->birth_date = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->address = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->comments = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->abcTabControl = (gcnew System::Windows::Forms::TabControl());
			this->tabPage1 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage2 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage3 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage4 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage5 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage6 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage7 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage8 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage9 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage10 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage11 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage12 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage13 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage14 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage15 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage16 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage17 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage18 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage19 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage20 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage21 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage22 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage23 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage24 = (gcnew System::Windows::Forms::TabPage());
			this->tabPage25 = (gcnew System::Windows::Forms::TabPage());
			this->notesTabPage = (gcnew System::Windows::Forms::TabPage());
			this->notesDataGridView = (gcnew System::Windows::Forms::DataGridView());
			this->id_notes = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->note_datetime = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->note = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->deleteButton = (gcnew System::Windows::Forms::Button());
			this->editButton = (gcnew System::Windows::Forms::Button());
			this->addButton = (gcnew System::Windows::Forms::Button());
			this->MainTabControl->SuspendLayout();
			this->addressTabPage->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->addressDataGridView))->BeginInit();
			this->abcTabControl->SuspendLayout();
			this->notesTabPage->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->notesDataGridView))->BeginInit();
			this->SuspendLayout();
			// 
			// MainTabControl
			// 
			this->MainTabControl->Controls->Add(this->addressTabPage);
			this->MainTabControl->Controls->Add(this->notesTabPage);
			this->MainTabControl->Location = System::Drawing::Point(11, 14);
			this->MainTabControl->Name = L"MainTabControl";
			this->MainTabControl->SelectedIndex = 0;
			this->MainTabControl->Size = System::Drawing::Size(1055, 491);
			this->MainTabControl->TabIndex = 1;
			// 
			// addressTabPage
			// 
			this->addressTabPage->BackColor = System::Drawing::Color::LightGray;
			this->addressTabPage->Controls->Add(this->addressDataGridView);
			this->addressTabPage->Controls->Add(this->abcTabControl);
			this->addressTabPage->Location = System::Drawing::Point(4, 22);
			this->addressTabPage->Name = L"addressTabPage";
			this->addressTabPage->Padding = System::Windows::Forms::Padding(3);
			this->addressTabPage->Size = System::Drawing::Size(1047, 465);
			this->addressTabPage->TabIndex = 0;
			this->addressTabPage->Text = L"Адресная книга";
			// 
			// addressDataGridView
			// 
			this->addressDataGridView->AllowUserToAddRows = false;
			this->addressDataGridView->AllowUserToDeleteRows = false;
			this->addressDataGridView->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->addressDataGridView->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(6) {
				this->id,
					this->name, this->phone, this->birth_date, this->address, this->comments
			});
			this->addressDataGridView->Location = System::Drawing::Point(7, 40);
			this->addressDataGridView->MultiSelect = false;
			this->addressDataGridView->Name = L"addressDataGridView";
			this->addressDataGridView->ReadOnly = true;
			this->addressDataGridView->SelectionMode = System::Windows::Forms::DataGridViewSelectionMode::FullRowSelect;
			this->addressDataGridView->Size = System::Drawing::Size(810, 408);
			this->addressDataGridView->TabIndex = 1;
			// 
			// id
			// 
			this->id->DataPropertyName = L"id";
			this->id->HeaderText = L"ИД";
			this->id->Name = L"id";
			this->id->ReadOnly = true;
			this->id->Visible = false;
			// 
			// name
			// 
			this->name->DataPropertyName = L"name";
			this->name->HeaderText = L"ФИО";
			this->name->Name = L"name";
			this->name->ReadOnly = true;
			this->name->ToolTipText = L"Фамилия, имя, отчествво";
			this->name->Width = 200;
			// 
			// phone
			// 
			this->phone->DataPropertyName = L"phone";
			this->phone->HeaderText = L"Тел.";
			this->phone->Name = L"phone";
			this->phone->ReadOnly = true;
			this->phone->ToolTipText = L"Телефон";
			// 
			// birth_date
			// 
			this->birth_date->DataPropertyName = L"birth_date";
			dataGridViewCellStyle4->Format = L"d";
			dataGridViewCellStyle4->NullValue = nullptr;
			this->birth_date->DefaultCellStyle = dataGridViewCellStyle4;
			this->birth_date->HeaderText = L"Дата рожд.";
			this->birth_date->Name = L"birth_date";
			this->birth_date->ReadOnly = true;
			this->birth_date->ToolTipText = L"Дата рождения";
			// 
			// address
			// 
			this->address->DataPropertyName = L"address";
			this->address->HeaderText = L"Адрес";
			this->address->Name = L"address";
			this->address->ReadOnly = true;
			this->address->ToolTipText = L"Адрес";
			this->address->Width = 350;
			// 
			// comments
			// 
			this->comments->DataPropertyName = L"comments";
			this->comments->HeaderText = L"Заметки";
			this->comments->Name = L"comments";
			this->comments->ReadOnly = true;
			this->comments->Visible = false;
			// 
			// abcTabControl
			// 
			this->abcTabControl->Controls->Add(this->tabPage1);
			this->abcTabControl->Controls->Add(this->tabPage2);
			this->abcTabControl->Controls->Add(this->tabPage3);
			this->abcTabControl->Controls->Add(this->tabPage4);
			this->abcTabControl->Controls->Add(this->tabPage5);
			this->abcTabControl->Controls->Add(this->tabPage6);
			this->abcTabControl->Controls->Add(this->tabPage7);
			this->abcTabControl->Controls->Add(this->tabPage8);
			this->abcTabControl->Controls->Add(this->tabPage9);
			this->abcTabControl->Controls->Add(this->tabPage10);
			this->abcTabControl->Controls->Add(this->tabPage11);
			this->abcTabControl->Controls->Add(this->tabPage12);
			this->abcTabControl->Controls->Add(this->tabPage13);
			this->abcTabControl->Controls->Add(this->tabPage14);
			this->abcTabControl->Controls->Add(this->tabPage15);
			this->abcTabControl->Controls->Add(this->tabPage16);
			this->abcTabControl->Controls->Add(this->tabPage17);
			this->abcTabControl->Controls->Add(this->tabPage18);
			this->abcTabControl->Controls->Add(this->tabPage19);
			this->abcTabControl->Controls->Add(this->tabPage20);
			this->abcTabControl->Controls->Add(this->tabPage21);
			this->abcTabControl->Controls->Add(this->tabPage22);
			this->abcTabControl->Controls->Add(this->tabPage23);
			this->abcTabControl->Controls->Add(this->tabPage24);
			this->abcTabControl->Controls->Add(this->tabPage25);
			this->abcTabControl->Location = System::Drawing::Point(-4, 0);
			this->abcTabControl->Name = L"abcTabControl";
			this->abcTabControl->SelectedIndex = 0;
			this->abcTabControl->Size = System::Drawing::Size(1056, 33);
			this->abcTabControl->TabIndex = 0;
			// 
			// tabPage1
			// 
			this->tabPage1->Location = System::Drawing::Point(4, 22);
			this->tabPage1->Name = L"tabPage1";
			this->tabPage1->Padding = System::Windows::Forms::Padding(3);
			this->tabPage1->Size = System::Drawing::Size(1048, 7);
			this->tabPage1->TabIndex = 0;
			this->tabPage1->Text = L"А";
			this->tabPage1->UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this->tabPage2->BackColor = System::Drawing::Color::WhiteSmoke;
			this->tabPage2->Location = System::Drawing::Point(4, 22);
			this->tabPage2->Name = L"tabPage2";
			this->tabPage2->Padding = System::Windows::Forms::Padding(3);
			this->tabPage2->Size = System::Drawing::Size(1048, 7);
			this->tabPage2->TabIndex = 1;
			this->tabPage2->Text = L"Б";
			// 
			// tabPage3
			// 
			this->tabPage3->Location = System::Drawing::Point(4, 22);
			this->tabPage3->Name = L"tabPage3";
			this->tabPage3->Size = System::Drawing::Size(1048, 7);
			this->tabPage3->TabIndex = 2;
			this->tabPage3->Text = L"В";
			this->tabPage3->UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this->tabPage4->Location = System::Drawing::Point(4, 22);
			this->tabPage4->Name = L"tabPage4";
			this->tabPage4->Size = System::Drawing::Size(1048, 7);
			this->tabPage4->TabIndex = 3;
			this->tabPage4->Text = L"Г";
			this->tabPage4->UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this->tabPage5->Location = System::Drawing::Point(4, 22);
			this->tabPage5->Name = L"tabPage5";
			this->tabPage5->Size = System::Drawing::Size(1048, 7);
			this->tabPage5->TabIndex = 4;
			this->tabPage5->Text = L"Е";
			this->tabPage5->UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this->tabPage6->Location = System::Drawing::Point(4, 22);
			this->tabPage6->Name = L"tabPage6";
			this->tabPage6->Size = System::Drawing::Size(1048, 7);
			this->tabPage6->TabIndex = 5;
			this->tabPage6->Text = L"Ж";
			this->tabPage6->UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			this->tabPage7->Location = System::Drawing::Point(4, 22);
			this->tabPage7->Name = L"tabPage7";
			this->tabPage7->Size = System::Drawing::Size(1048, 7);
			this->tabPage7->TabIndex = 6;
			this->tabPage7->Text = L"З";
			this->tabPage7->UseVisualStyleBackColor = true;
			// 
			// tabPage8
			// 
			this->tabPage8->Location = System::Drawing::Point(4, 22);
			this->tabPage8->Name = L"tabPage8";
			this->tabPage8->Size = System::Drawing::Size(1048, 7);
			this->tabPage8->TabIndex = 7;
			this->tabPage8->Text = L"И";
			this->tabPage8->UseVisualStyleBackColor = true;
			// 
			// tabPage9
			// 
			this->tabPage9->Location = System::Drawing::Point(4, 22);
			this->tabPage9->Name = L"tabPage9";
			this->tabPage9->Size = System::Drawing::Size(1048, 7);
			this->tabPage9->TabIndex = 8;
			this->tabPage9->Text = L"К";
			this->tabPage9->UseVisualStyleBackColor = true;
			// 
			// tabPage10
			// 
			this->tabPage10->Location = System::Drawing::Point(4, 22);
			this->tabPage10->Name = L"tabPage10";
			this->tabPage10->Size = System::Drawing::Size(1048, 7);
			this->tabPage10->TabIndex = 9;
			this->tabPage10->Text = L"Л";
			this->tabPage10->UseVisualStyleBackColor = true;
			// 
			// tabPage11
			// 
			this->tabPage11->Location = System::Drawing::Point(4, 22);
			this->tabPage11->Name = L"tabPage11";
			this->tabPage11->Size = System::Drawing::Size(1048, 7);
			this->tabPage11->TabIndex = 10;
			this->tabPage11->Text = L"М";
			this->tabPage11->UseVisualStyleBackColor = true;
			// 
			// tabPage12
			// 
			this->tabPage12->Location = System::Drawing::Point(4, 22);
			this->tabPage12->Name = L"tabPage12";
			this->tabPage12->Size = System::Drawing::Size(1048, 7);
			this->tabPage12->TabIndex = 11;
			this->tabPage12->Text = L"Н";
			this->tabPage12->UseVisualStyleBackColor = true;
			// 
			// tabPage13
			// 
			this->tabPage13->Location = System::Drawing::Point(4, 22);
			this->tabPage13->Name = L"tabPage13";
			this->tabPage13->Size = System::Drawing::Size(1048, 7);
			this->tabPage13->TabIndex = 12;
			this->tabPage13->Text = L"О";
			this->tabPage13->UseVisualStyleBackColor = true;
			// 
			// tabPage14
			// 
			this->tabPage14->Location = System::Drawing::Point(4, 22);
			this->tabPage14->Name = L"tabPage14";
			this->tabPage14->Size = System::Drawing::Size(1048, 7);
			this->tabPage14->TabIndex = 13;
			this->tabPage14->Text = L"П";
			this->tabPage14->UseVisualStyleBackColor = true;
			// 
			// tabPage15
			// 
			this->tabPage15->Location = System::Drawing::Point(4, 22);
			this->tabPage15->Name = L"tabPage15";
			this->tabPage15->Size = System::Drawing::Size(1048, 7);
			this->tabPage15->TabIndex = 14;
			this->tabPage15->Text = L"Р";
			this->tabPage15->UseVisualStyleBackColor = true;
			// 
			// tabPage16
			// 
			this->tabPage16->Location = System::Drawing::Point(4, 22);
			this->tabPage16->Name = L"tabPage16";
			this->tabPage16->Size = System::Drawing::Size(1048, 7);
			this->tabPage16->TabIndex = 15;
			this->tabPage16->Text = L"С";
			this->tabPage16->UseVisualStyleBackColor = true;
			// 
			// tabPage17
			// 
			this->tabPage17->Location = System::Drawing::Point(4, 22);
			this->tabPage17->Name = L"tabPage17";
			this->tabPage17->Size = System::Drawing::Size(1048, 7);
			this->tabPage17->TabIndex = 16;
			this->tabPage17->Text = L"Т";
			this->tabPage17->UseVisualStyleBackColor = true;
			// 
			// tabPage18
			// 
			this->tabPage18->Location = System::Drawing::Point(4, 22);
			this->tabPage18->Name = L"tabPage18";
			this->tabPage18->Size = System::Drawing::Size(1048, 7);
			this->tabPage18->TabIndex = 17;
			this->tabPage18->Text = L"У";
			this->tabPage18->UseVisualStyleBackColor = true;
			// 
			// tabPage19
			// 
			this->tabPage19->Location = System::Drawing::Point(4, 22);
			this->tabPage19->Name = L"tabPage19";
			this->tabPage19->Size = System::Drawing::Size(1048, 7);
			this->tabPage19->TabIndex = 18;
			this->tabPage19->Text = L"Ф";
			this->tabPage19->UseVisualStyleBackColor = true;
			// 
			// tabPage20
			// 
			this->tabPage20->Location = System::Drawing::Point(4, 22);
			this->tabPage20->Name = L"tabPage20";
			this->tabPage20->Size = System::Drawing::Size(1048, 7);
			this->tabPage20->TabIndex = 19;
			this->tabPage20->Text = L"Х";
			this->tabPage20->UseVisualStyleBackColor = true;
			// 
			// tabPage21
			// 
			this->tabPage21->Location = System::Drawing::Point(4, 22);
			this->tabPage21->Name = L"tabPage21";
			this->tabPage21->Size = System::Drawing::Size(1048, 7);
			this->tabPage21->TabIndex = 20;
			this->tabPage21->Text = L"Ш";
			this->tabPage21->UseVisualStyleBackColor = true;
			// 
			// tabPage22
			// 
			this->tabPage22->Location = System::Drawing::Point(4, 22);
			this->tabPage22->Name = L"tabPage22";
			this->tabPage22->Size = System::Drawing::Size(1048, 7);
			this->tabPage22->TabIndex = 21;
			this->tabPage22->Text = L"Щ";
			this->tabPage22->UseVisualStyleBackColor = true;
			// 
			// tabPage23
			// 
			this->tabPage23->Location = System::Drawing::Point(4, 22);
			this->tabPage23->Name = L"tabPage23";
			this->tabPage23->Size = System::Drawing::Size(1048, 7);
			this->tabPage23->TabIndex = 22;
			this->tabPage23->Text = L"Э";
			this->tabPage23->UseVisualStyleBackColor = true;
			// 
			// tabPage24
			// 
			this->tabPage24->Location = System::Drawing::Point(4, 22);
			this->tabPage24->Name = L"tabPage24";
			this->tabPage24->Size = System::Drawing::Size(1048, 7);
			this->tabPage24->TabIndex = 23;
			this->tabPage24->Text = L"Ю";
			this->tabPage24->UseVisualStyleBackColor = true;
			// 
			// tabPage25
			// 
			this->tabPage25->Location = System::Drawing::Point(4, 22);
			this->tabPage25->Name = L"tabPage25";
			this->tabPage25->Size = System::Drawing::Size(1048, 7);
			this->tabPage25->TabIndex = 24;
			this->tabPage25->Text = L"Я";
			this->tabPage25->UseVisualStyleBackColor = true;
			// 
			// notesTabPage
			// 
			this->notesTabPage->BackColor = System::Drawing::Color::LightGray;
			this->notesTabPage->Controls->Add(this->notesDataGridView);
			this->notesTabPage->Location = System::Drawing::Point(4, 22);
			this->notesTabPage->Name = L"notesTabPage";
			this->notesTabPage->Padding = System::Windows::Forms::Padding(3);
			this->notesTabPage->Size = System::Drawing::Size(1047, 465);
			this->notesTabPage->TabIndex = 1;
			this->notesTabPage->Text = L"Заметки";
			// 
			// notesDataGridView
			// 
			this->notesDataGridView->AllowUserToAddRows = false;
			this->notesDataGridView->AllowUserToDeleteRows = false;
			this->notesDataGridView->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->notesDataGridView->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(3) {
				this->id_notes,
					this->note_datetime, this->note
			});
			this->notesDataGridView->Location = System::Drawing::Point(7, 7);
			this->notesDataGridView->MultiSelect = false;
			this->notesDataGridView->Name = L"notesDataGridView";
			this->notesDataGridView->ReadOnly = true;
			this->notesDataGridView->SelectionMode = System::Windows::Forms::DataGridViewSelectionMode::FullRowSelect;
			this->notesDataGridView->Size = System::Drawing::Size(1014, 433);
			this->notesDataGridView->TabIndex = 0;
			// 
			// id_notes
			// 
			this->id_notes->DataPropertyName = L"id";
			this->id_notes->HeaderText = L"ИД";
			this->id_notes->Name = L"id_notes";
			this->id_notes->ReadOnly = true;
			this->id_notes->Visible = false;
			this->id_notes->Width = 40;
			// 
			// note_datetime
			// 
			this->note_datetime->DataPropertyName = L"note_datetime";
			dataGridViewCellStyle5->Format = L"g";
			dataGridViewCellStyle5->NullValue = nullptr;
			this->note_datetime->DefaultCellStyle = dataGridViewCellStyle5;
			this->note_datetime->HeaderText = L"Дата и время";
			this->note_datetime->Name = L"note_datetime";
			this->note_datetime->ReadOnly = true;
			// 
			// note
			// 
			this->note->DataPropertyName = L"comments";
			dataGridViewCellStyle6->WrapMode = System::Windows::Forms::DataGridViewTriState::True;
			this->note->DefaultCellStyle = dataGridViewCellStyle6;
			this->note->HeaderText = L"Заметки";
			this->note->Name = L"note";
			this->note->ReadOnly = true;
			this->note->Width = 500;
			// 
			// deleteButton
			// 
			this->deleteButton->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"deleteButton.Image")));
			this->deleteButton->Location = System::Drawing::Point(1116, 216);
			this->deleteButton->Name = L"deleteButton";
			this->deleteButton->Size = System::Drawing::Size(64, 64);
			this->deleteButton->TabIndex = 6;
			this->deleteButton->UseVisualStyleBackColor = true;
			// 
			// editButton
			// 
			this->editButton->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"editButton.Image")));
			this->editButton->Location = System::Drawing::Point(1116, 126);
			this->editButton->Name = L"editButton";
			this->editButton->Size = System::Drawing::Size(64, 64);
			this->editButton->TabIndex = 5;
			this->editButton->UseVisualStyleBackColor = true;
			// 
			// addButton
			// 
			this->addButton->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"addButton.Image")));
			this->addButton->Location = System::Drawing::Point(1116, 36);
			this->addButton->Name = L"addButton";
			this->addButton->Size = System::Drawing::Size(64, 64);
			this->addButton->TabIndex = 4;
			this->addButton->UseVisualStyleBackColor = true;
			this->addButton->Click += gcnew System::EventHandler(this, &MainForm::addButton_Click);
			// 
			// MainForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1199, 517);
			this->Controls->Add(this->deleteButton);
			this->Controls->Add(this->editButton);
			this->Controls->Add(this->addButton);
			this->Controls->Add(this->MainTabControl);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"MainForm";
			this->Text = L"Моя записная книжка";
			this->Load += gcnew System::EventHandler(this, &MainForm::OnLoad);
			this->MainTabControl->ResumeLayout(false);
			this->addressTabPage->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->addressDataGridView))->EndInit();
			this->abcTabControl->ResumeLayout(false);
			this->notesTabPage->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->notesDataGridView))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void OnLoad(System::Object^ sender, System::EventArgs^ e) 
	{
		
	}
private: System::Void addButton_Click(System::Object^ sender, System::EventArgs^ e) {
}
};
}
