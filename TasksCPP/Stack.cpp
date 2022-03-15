#pragma once
#include <string>
template <typename T>
class Stack
{
	T* data; // ������ ������
	int data_size; // ����� ��������� � �����
	int capacity; // ����������� �����
	int popcount; // ����� ������������ �� �����
	/// <summary>
	/// ��������� ������ �����
	/// </summary>
	void resize()
	{
		// ��������� ��������� ������
		T* buffer = new T[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// ��������� ������ ������
		capacity += 16;
		delete data;
		data = new T[capacity];
		// ��������� ���������� ������
		for (int i = 0; i < data_size; i++)
		{
			data[i] = buffer[i];
		}
		delete [] buffer;
	}

	/// <summary>
	/// ����� ������ �����
	/// </summary>
	void shrink()
	{
		// ��������� ��������� ������
		T* buffer = new T[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// ����� ������ ������
		capacity -= 16;
		data_size = capacity;
		delete data;
		data = new T[capacity];
		// ��������� ���������� ������
		for (int i = 0; i < data_size; i++)
		{
			data[i] = buffer[i];
		}
		delete buffer;

	}
public:
	Stack()
	{
		capacity = 16;
		data_size = 0;
		popcount = 0;
		data = new T[capacity];
	}
	~Stack()
	{
		delete data; 
	}

	/// <summary>
	/// �������� ������� � ����
	/// </summary>
	/// <param name="element">�������</param>
	void push(T element)
	{
		if (data_size + 1 > capacity) resize();

		memcpy(data + data_size, &element, sizeof(T));
		data_size++;
	}
	/// <summary>
	/// ������ ������� �� �����
	/// </summary>
	/// <returns>����� ��������� ��������</returns>
	T* pop()
	{
		if (data_size < 1) return nullptr;
		popcount++;
			if (popcount = 16 && data_size > 16) { shrink(); popcount = 0; }
			T* val = data + data_size-1;
			data_size--;
			return val;

	}
	int size() { return data_size; }
	const T* getdata() { return data; }

};

template <>
class Stack<std::string>
{
	std::string * data; // ������ ������
	int data_size; // ����� ��������� � �����
	int capacity; // ����������� �����
	int popcount; // ����� ������������ �� �����
	// ��������� ������ ����� ��� �������� �� 16 ���������
	/// <summary>
	/// ��������� ������ �����
	/// </summary>
	void resize()
	{
		// ��������� ��������� ������
		std::string* buffer = new std::string[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// ��������� ������ ������
		capacity += 16;
		delete [] data;
		data = new std::string[capacity];
		// ��������� ���������� ������
		for (int i = 0; i < data_size; i++)
		{
			data[i] = buffer[i];
		}
		delete [] buffer;
	}

	/// <summary>
	/// ����� ������ �����
	/// </summary>
	void shrink()
	{
		// ��������� ��������� ������
		std::string* buffer = new std::string[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// ����� ������ ������
		capacity -= 16;
		data_size = capacity;
		delete [] data;
		data = new std::string[capacity];
		// ��������� ���������� ������
		for (int i = 0; i < data_size; i++)
		{
			data[i] = buffer[i];
		}
		delete [] buffer;

	}
public:
	Stack()
	{
		capacity = 16;
		data_size = 0;
		popcount = 0;
		data = new std::string[capacity];
	}
	~Stack()
	{
		delete [] data;
	}

	/// <summary>
	/// �������� ������� � ����
	/// </summary>
	/// <param name="element">�������</param>
	void push(std::string element)
	{
		if (data_size + 1 > capacity) resize();
		data[data_size] = element;
		data_size++;
	}
	/// <summary>
	/// ������ ������� �� �����
	/// </summary>
	/// <returns>����� ��������� ��������</returns>
	std::string pop()
	{
		std::string val = "";
		if (data_size < 1) return val;
		popcount++;
		if (popcount = 16 && data_size > 16) { shrink(); popcount = 0; }
		val = data[data_size - 1];
		data_size--;
		return val;

	}
	int size() { return data_size; }
	const std::string* getdata() { return data; }

};