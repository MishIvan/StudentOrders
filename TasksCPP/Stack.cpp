#pragma once
#include <string>
template <typename T>
class Stack
{
	T* data; // массив данных
	int data_size; // число элементов в стеке
	int capacity; // вместимость стека
	int popcount; // число выталкиваний из стека
	/// <summary>
	/// Увеличить размер стека
	/// </summary>
	void resize()
	{
		// сохранить имеющиеся данные
		T* buffer = new T[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// расширить массив данных
		capacity += 16;
		delete data;
		data = new T[capacity];
		// перенести сохранённые данные
		for (int i = 0; i < data_size; i++)
		{
			data[i] = buffer[i];
		}
		delete [] buffer;
	}

	/// <summary>
	/// Сжать размер стека
	/// </summary>
	void shrink()
	{
		// сохранить имеющиеся данные
		T* buffer = new T[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// сжать массив данных
		capacity -= 16;
		data_size = capacity;
		delete data;
		data = new T[capacity];
		// перенести сохранённые данные
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
	/// Вставить элемент в стек
	/// </summary>
	/// <param name="element">элемент</param>
	void push(T element)
	{
		if (data_size + 1 > capacity) resize();

		memcpy(data + data_size, &element, sizeof(T));
		data_size++;
	}
	/// <summary>
	/// Убрать элемент из стека
	/// </summary>
	/// <returns>адрес убранного элемента</returns>
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
	std::string * data; // массив данных
	int data_size; // число элементов в стеке
	int capacity; // вместимость стека
	int popcount; // число выталкиваний из стека
	// выделение памяти стека идёт квантами по 16 элементов
	/// <summary>
	/// Увеличить размер стека
	/// </summary>
	void resize()
	{
		// сохранить имеющиеся данные
		std::string* buffer = new std::string[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// расширить массив данных
		capacity += 16;
		delete [] data;
		data = new std::string[capacity];
		// перенести сохранённые данные
		for (int i = 0; i < data_size; i++)
		{
			data[i] = buffer[i];
		}
		delete [] buffer;
	}

	/// <summary>
	/// Сжать размер стека
	/// </summary>
	void shrink()
	{
		// сохранить имеющиеся данные
		std::string* buffer = new std::string[data_size];
		for (int i = 0; i < data_size; i++)
		{
			buffer[i] = data[i];
		}

		// сжать массив данных
		capacity -= 16;
		data_size = capacity;
		delete [] data;
		data = new std::string[capacity];
		// перенести сохранённые данные
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
	/// Вставить элемент в стек
	/// </summary>
	/// <param name="element">элемент</param>
	void push(std::string element)
	{
		if (data_size + 1 > capacity) resize();
		data[data_size] = element;
		data_size++;
	}
	/// <summary>
	/// Убрать элемент из стека
	/// </summary>
	/// <returns>адрес убранного элемента</returns>
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