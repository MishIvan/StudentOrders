#include "MATRIX.h"
#include <thread>

/// <summary>
/// ����������� ������� M x N, ���� ��������� ������� ������������� �������� val
/// </summary>
/// <param name="M">����� ����� �������</param>
/// <param name="N">����� �������� �������</param>
/// <param name="val"></param>
MATRIX::MATRIX(int M, int N, double val)
{
	m_columns = m_rows = 0;
	m_data = 0;
	if (M < 0 || N < 0)
	{
		throw invalid_argument("������ ������������� ����������� �������");
		return;
	}
	m_rows = M; m_columns = N;
	this->m_data = new double[this->m_rows * this->m_columns];
	for (int i = 0; i < M; i++)
		for (int j = 0; j < N; j++)
			*(m_data + i * m_columns + j) = val;
}
/// <summary>
/// ����������� ����������� ������� �� ������� src 
/// </summary>
/// <param name="src">�������� ������� ��� �����������</param>
MATRIX::MATRIX(const MATRIX& src)
{
	if (!this->m_data) delete[] this->m_data;
	this->m_columns = src.m_columns;
	this->m_rows = src.m_rows;
	this->m_data = new double[this->m_rows * this->m_columns];
	for (int i = 0; i < this->m_rows; i++)
		for (int j = 0; j < this->m_columns; j++)
			*(this->m_data + i * this->m_columns + j) = *(src.m_data + i*src.m_columns +j);
}
/// <summary>
/// ���������� ��������� ������������
/// </summary>
/// <param name="src">������� ��� ������������</param>
/// <returns></returns>
MATRIX& MATRIX::operator=(const MATRIX& src)
{
	if (!this->m_data) delete[] this->m_data;
	this->m_columns = src.m_columns;
	this->m_rows = src.m_rows;
	this->m_data = new double[this->m_rows * this->m_columns];
	for (int i = 0; i < this->m_rows; i++)
		for (int j = 0; j < this->m_columns; j++)
			*(this->m_data + i * this->m_columns + j) = *(src.m_data + i * src.m_columns + j);
	return *this;
}
/// <summary>
/// ������� �������
/// </summary>
/// <param name="i">������</param>
/// <param name="j">�������</param>
/// <returns>������� �� i-�� ������ � j-�� �������</returns>
double& MATRIX::operator()(int i, int j)
{
	return *(m_data + i * m_columns + j);
}
/// <summary>
/// ���������� ��������� ��������� ������ matr1 � matr2
/// ����� �������� ������� matr1 ������ ���� ����� ����� ����� ������� matr2
/// </summary>
/// <param name="matr1">������ �������</param>
/// <param name="matr2">������ �������</param>
/// <returns>�������, ������������</returns>
MATRIX operator*(const MATRIX& matr1, const MATRIX& matr2)
{
	MATRIX pmatr(matr1.m_rows, matr2.m_columns);
	if (matr1.m_columns != matr2.m_rows) return pmatr;
	int i, j;
	for(i = 0; i < matr1.m_rows; i++)
		for (j = 0; j < matr2.m_columns; j++)
		{
			double prod = 0.0;
			for (int k = 0; k < matr1.m_columns; k++)
				prod += *(matr1.m_data + i * matr1.m_columns + k) * *(matr2.m_data + k * matr2.m_columns + j);
			*(pmatr.m_data + i * pmatr.m_columns + j) = prod;
		}
	return pmatr;
}
/// <summary>
/// ���������� ��������� ������ �� ������� ��� � �������� ����� (���� ������ ���� ������ ��� ������) 
/// ������� ��������� ���������
/// </summary>
/// <param name="s"></param>
/// <param name="matr">�������</param>
/// <returns></returns>
ostream& operator<<(ostream& s, MATRIX& matr)
{
	int m = matr.m_rows;
	int n = matr.m_columns;
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++) // ����� ������ � �����
			s << *(matr.m_data + i * n + j) << ' ';
		s << endl;
	}
	return s;
}
/// <summary>
/// ���������� ��������� ����� � ������� ��� � �������� ����� (���� ������ ���� ������ ��� ������) 
/// ������� �������� ���������
/// </summary>
/// <param name="s"></param>
/// <param name="matr">�������</param>
/// <returns>�����</returns>
istream& operator>>(istream& s, MATRIX& matr)
{
	int m = matr.m_rows;
	int n = matr.m_columns;
	double* buff = new double[n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++) // ���������� ������ �������
			s >> *(buff + j);
		for (int j = 0; j < n; j++) // ������ ������ �������
			*(matr.m_data + i * n + j) = *(buff + j);

	}
	delete[] buff;
	return s;
}
/// <summary>
/// ���������� ������������ ���������� �������
/// </summary>
/// <returns></returns>
double MATRIX::Determinant()
{
	if(m_rows != m_columns) return NAN;
	MATRIX alpha(m_rows, m_columns);
	return FormMatrixCompactScheme(alpha);
}
/// <summary>
/// ���������� ������ �� ����� � �������� �� � ������� matr
/// </summary>
/// <param name="fileName">������ ��� �����</param>
/// <param name="matr">�������</param>
/// <returns>true - � ������ ��������� ���������� ������, false - � ������ ������</returns>
bool MATRIX::readFromFile(const char* fileName, MATRIX& matr)
{
	ifstream fs;
	fs.open(fileName);
	if (fs.is_open())
	{
		fs >> matr.m_rows >> matr.m_columns;
		fs >> matr;
		fs.close();
		return true;
	}
	return false;
}
/// <summary>
///  ������ ������ � ����
/// </summary>
/// <param name="fileName">������ ��� ����� ��� ������</param>
/// <returns>true - � ������ ��������� ���������� ������, false - � ������ ������</returns>
bool MATRIX::writeToFile(const char* fileName, MATRIX& matr)
{
	ofstream fs;
	fs.open(fileName);
	if(fs.is_open()){
		fs << matr.m_rows << ' ' << matr.m_columns << endl;
		fs << matr;
		fs.close();
		return true;
	}
	return false;
}
/// <summary>
/// �������� �� ���������� ������� ������������
/// </summary>
/// <returns></returns>
bool MATRIX::IsSymmetric()
{
	if (m_rows != m_columns)
	{
		throw "������������ ����� ���� ������ ���������� �������";
		return false;
	}
	int n = m_rows;
	for(int i=0; i < n; i++)
		for (int j = 0; j < n; j++)
		{
			if (*(m_data + i*n + j) != *(m_data + j*n + i)) return false;
		}
	return true;
}
/// <summary>
/// ��������� ������ matr �� ������ v
/// </summary>
/// <param name="matr">�������</param>
/// <param name="v">������</param>
/// <returns>��������� ���������, ������</returns>
VECTOR operator*(const MATRIX& matr, const VECTOR& v)
{
	VECTOR prod(matr.m_rows);
	if (matr.m_columns != v.m_size) return prod;
	for (int i = 0; i < matr.m_rows; i++)
	{
		double val = 0.0;
		for (int j = 0; j < matr.m_columns; j++)
			val += *(matr.m_data + i * matr.m_columns + j) * *(v.m_data + j);
		*(prod.m_data + i) = val;
	}
	return prod;
}
/// <summary>
/// QR ���������� ���������� �������
/// </summary>
/// <param name="Q">������� Q</param>
/// <param name="R">������� R</param>
bool MATRIX::QRDecomposition(MATRIX& Q, MATRIX& R)
{
	if (m_columns != m_rows) return false;
	int n = m_rows;
	double sum = 0.0;

	for (int j = 0; j < n; j++)
	{
		// q(j) = a(j)
		for (int k = 0; k < n; k++)
			*(Q.m_data + k * n + j) = *(m_data + k * n + j);

		for (int i = 0; i <= j - 1; i++)
		{
			// rij = q(i)^T*a(j)
			sum = 0.0;
			for (int k = 0; k < n; k++)
				sum += *(Q.m_data + k* n + i) * *(m_data + k * n + j);
			*(R.m_data + i * n + j) = sum;

			// r(i,j)*q(i)
			for(int k=0; k < n; k++)
				*(Q.m_data + k * n + j) -= *(R.m_data + i * n + j) * *(Q.m_data + k * n + i);
		}

		// r(j,j) = || q(j)) ||2
		sum = 0.0;
		for (int k = 0; k < n; k++)
			sum += *(Q.m_data + k * n + j) * *(Q.m_data + k * n + j);
		*(R.m_data + j * n + j) = sqrt(sum);

		if (*(R.m_data + j * n + j) == 0.0)
		{
			return false;
		}
		for (int k = 0; k < n; k++)
			*(Q.m_data + k * n + j) /= *(R.m_data + j * n + j);

	}
	
	return true;
}
/// <summary>
///  ���������� ��������� ������� A = L*L^t
/// </summary>
/// <param name="L">������� � ���������� ���������</param>
/// <returns></returns>
bool MATRIX::CholeskyDecomposition(MATRIX& L)
{
	if (m_rows != m_columns) return false;
	int n = m_rows;
	for (int i = 0; i < n; i++) 
		for (int j = 0; j <= i; j++) {

			double sum = 0;
			for (int k = 0; k < j; k++) 
				sum += *(L.m_data + i*n + k) * *(L.m_data + j*n + k);

			if (i == j)
			{
				*(L.m_data + i * n + j) = sqrt(*(m_data + i * n + i) - sum);
				if ( *(L.m_data + i * n + j) <= 0.0 || isnan(*(L.m_data + i * n + j)) ) return false;
			}
			else 
				*(L.m_data + i * n + j) = (*(m_data + i * n + j) - sum)/(*(L.m_data + j * n + j));
		}
	
	return true;
}
/// <summary>
/// ��������� ����������������� ������� 
/// </summary>
/// <returns>����������������� �������</returns>
MATRIX MATRIX::Transpose()
{
	MATRIX tr(m_columns, m_rows);
	for (int i = 0; i < m_columns; i++)
		for (int j = 0; j < m_rows; j++)
			*(tr.m_data + i * tr.m_columns + j) = *(m_data + j * m_columns + i);
	return tr;
}

/// <summary>
/// ����������: ������������ ������, ���������� ��� �������
/// </summary>
MATRIX::~MATRIX()
{
	if (!m_data) delete[] m_data;
}


/// <summary>
/// ��������� ���������� ��������� ���� ������� ��������� � ������ val
/// </summary>
/// <param name="val">��������</param>
/// <returns>���������� ���������</returns>

int MATRIXEXT::getCountNotNumsUnderMD(double val) {
	int count = 0;
	for (int i = 0; i < m_rows; ++i) {
		for (int j = 0; j < m_columns; j++) {
			// �������� �������� ���� ������� ���������
			if (i > j) {
				if (*(m_data + i*m_columns + j) == val) count++;
			}
		}
	}
	return count;
}
/// <summary>
/// ������� ������� �������� �������������� ��������� (����) ������� ������ � ����������� ������������ ������� ������� 
/// </summary>
/// <param name="a">������� ������������� ����</param>
/// <param name="b">������ ������ ����� ����</param>
/// <param name="x">������� ����</param>
/// <param name="det">������������ ������� a</param>
/// <returns></returns>
bool Gauss(const MATRIX &a, const VECTOR &b, VECTOR &x)
{
	int i, k, m;
	long double amm, aim;

	// ������� ������ ���� ���������� � ����������� ������� ������ ��������� 
	// � ������������ �������
	if (a.m_columns != b.m_size || a.m_columns != a.m_rows) return false;
	int size = a.m_rows;

	// �������� �������� ������� � ������� � ������� ����������� ��������
	MATRIX alf(size, size);
	VECTOR bet(size);
	alf = a;
	bet = b;
	for (m = 0; m <= size - 2; m++)
	{
		amm =  *(alf.m_data + m * size + m);
		for (k = m; k <= size - 1; k++)
			*(alf.m_data + m*size + k) /= amm;
		*(bet.m_data + m)/= amm;
		for (i = m + 1; i <= size - 1; i++)
		{
			aim = *(alf.m_data +i*size + m);
			for (k = m; k <= size - 1; k++)
				*(alf.m_data +i*size + k) -= *(alf.m_data + m*size + k) * aim;
			*(bet.m_data + i) -= *(bet.m_data + m) * aim;
		}//end i 
	}//end m 

	// ���������� ������� ���� � ������� ����������� ��������
	*(x.m_data + size - 1) = *(bet.m_data +size - 1) / *(alf.m_data + size*(size - 1) + size - 1);
	for (i = size - 2; i >= 0; i--)
	{
		*(x.m_data + i) = *(bet.m_data +i);
		for (k = i + 1; k < size; k++)
			*(x.m_data + i) -= *(alf.m_data + i*size +k) * *(x.m_data + k);
	}//end i
	return true;
	
}
/// <summary>
/// ������������ ������ alpha � gamma � ���������� ����� ����������
/// ������� alpha ������� �����������, gamma - ������ �����������
/// </summary>
/// <param name="alpha">����������� �������</param>
/// <returns>�������� ������������ �������</returns>
double MATRIX::FormMatrixCompactScheme(MATRIX& alpha)
{
	if (this->m_columns != this->m_rows) return NAN;
	int n = this->m_rows;

	for (int i = 0; i < n; i++)
	{
		*(alpha.m_data +i * n) = *(this->m_data + i * n);
		if (i > 0) *(alpha.m_data + i) = *(this->m_data +i) / *this->m_data;
	}

	double sum = 0.0;
	int k = 1, i = 1;
	while (i < n)
	{
		if (k >= n)
		{
			k = 1; i++;
			if (i >= n) break;
		}
		if (i >= k)
		{
			sum = 0.0;
			for (int j = 0; j <= k - 1; j++)
			{
				sum += *(alpha.m_data +i * n + j) * *(alpha.m_data +j * n + k);
			}
			*(alpha.m_data +i * n + k) = *(this->m_data +i * n + k) - sum;
		}
		else
		{
			sum = 0.0;
			for (int j = 0; j <= i - 1; j++)
			{
				sum += *(alpha.m_data + i * n + j) * *(alpha.m_data +j * n + k);
			}
			if (abs(*(alpha.m_data + i * n + i)) < 1.0e-18)
			{
				return 0.0;
			}
			*(alpha.m_data + i * n + k) = (*(this->m_data +i * n + k) - sum) / *(alpha.m_data +i * n + i);
		}
		k++;
	}

	// ���������� ������������
	double det = 1.0;
	for (int i = 0; i < n; i++)
		det *= *(alpha.m_data + i * n + i);
	return det;
}

/// <summary>
/// ������� ������� �������� ��������� ���������� ������ ����������
/// </summary>
/// <param name="A">������� ������� ���������</param>
/// <param name="b">������ ������ ����� ������� ���������</param>
/// <param name="x">������� ������� ���������</param>
void CompactSchemeSolve(MATRIX &A, VECTOR& b, VECTOR& x)
{
	if (A.m_rows != A.m_columns) return;
	int n = A.m_rows;
	MATRIX alpha(n , n);
	double det = A.FormMatrixCompactScheme(alpha);
	// ������� ������ ��� ����������� �������
	if (det != 0.0)
	{
		VECTOR beta(n);
		double sum = 0.0;
		*beta.m_data = *b.m_data / *A.m_data;
		for (int i = 1; i < n; i++)
		{
			sum = 0.0;
			for (int j = 0; j <= i - 1; j++)
				sum += *(alpha.m_data + i * n + j) * *(beta.m_data +j);
			*(beta.m_data +i) = (*(b.m_data+i) - sum) / *(alpha.m_data + i * n + i);
		}

		// ������� ������� ��������� � ����������� ��������		   
		*(x.m_data + n - 1) = *(beta.m_data + n - 1);
		for (int i = n - 2; i >= 0; i--)
		{
			sum = 0.0;
			for (int j = n - 1; j > i; j--)
				sum += *(alpha.m_data +i * n + j) * *(x.m_data + j);
			*(x.m_data + i) = *(beta.m_data + i) - sum;
		}
	}
	
}
/// <summary>
/// ������� ���� � ����������� QR ������������ ������� ������� A
/// </summary>
/// <param name="A">������� ������� �������� ���������</param>
/// <param name="b">������ ������ ����� ������� �������� ���������</param>
/// <param name="x">������ ������� ������� �������� ���������</param>
void QRDecompositionSolve(MATRIX& A, VECTOR& b, VECTOR& x)
{ 
	if (A.m_rows != A.m_columns || A.m_rows != b.m_size) return;
	MATRIX Q(A.m_rows, A.m_columns), R(A.m_rows, A.m_columns);
	int n = A.m_rows;
	A.QRDecomposition(Q, R);
	VECTOR beta(b.m_size);
	beta = Q.Transpose() * b;
	cout << beta << endl;

	// ������� ������� ��������� � ������� ����������� ��������		   
	*(x.m_data + n - 1) = *(beta.m_data + n - 1)/ *(R.m_data + (n - 1)*n + n - 1);
	for (int i = n - 2; i >= 0; i--)
	{
		double sum = 0.0;
		for (int j = n - 1; j > i; j--)
			sum += *(R.m_data + i * n + j) * *(x.m_data + j);
		*(x.m_data + i) = (*(beta.m_data + i) - sum) / *(R.m_data + i*n + i);
	}


}
/// <summary>
/// ������� ������� ��������� � ����������� ������ LLT ������������ A = LLT
/// </summary>
/// <param name="A"></param>
/// <param name="b"></param>
/// <param name="x"></param>
void LLTDecompositionSolve(MATRIX& A, VECTOR& b, VECTOR& x)
{
	if (A.m_rows != A.m_columns || A.m_rows != b.m_size) return;

	MATRIX L(A.m_rows, A.m_columns), Anorm(A.m_rows, A.m_columns);
	VECTOR bet(A.m_rows);

	int n = A.m_rows;
	if (!A.CholeskyDecomposition(L))
	{
		MATRIX At(A.m_rows, A.m_columns);
		At = A.Transpose();
		Anorm =  At * A; // ������������ �������
		bet = At * b;
		Anorm.CholeskyDecomposition(L);
	}
	else
	{
		Anorm = A; bet = b;
	}

	// ������� ������� � ������� ����������� �������� Ly = b
	VECTOR y(n);
	for (int i = 0; i < n; i++)
	{
		*(y.m_data + i) = *(bet.m_data + i);
		double sum = 0.0;
		for (int k = 0; k < i; k++)
		{
			sum += *(L.m_data + i * n + k) * *(y.m_data + k);
		}
		*(y.m_data + i) -= sum;
		*(y.m_data + i) /= *(L.m_data + i * n + i);
		
	}

	L = L.Transpose();
	// ������� ������� ��������� � ������� ����������� �������� L^tx = y   
	*(x.m_data + n - 1) = *(y.m_data + n - 1) / *(L.m_data + (n - 1) * n + n - 1);
	for (int i = n - 2; i >= 0; i--)
	{
		double sum = 0.0;
		for (int j = n - 1; j > i; j--)
			sum += *(L.m_data + i * n + j) * *(x.m_data + j);
		*(x.m_data + i) = (*(y.m_data + i) - sum) / *(L.m_data + i * n + i);
	}


}
/// <summary>
/// ���������� ������ ����������� �������
/// </summary>
/// <param name="i">������</param>
/// <param name="j">�������</param>
/// <returns>�������� ������, � ������ ������ NAN</returns>
double MATRIX::Minor(int i, int j)
{
	int n = m_rows;
	if (m_columns != m_rows)
	{
		throw "������ ����������� ������ ��� ���������� �������";
		return NAN;
	}
	if (i < 0 || j < 0 || i > n - 1 || j > n - 1 || m_columns != m_rows) 
	{
		throw "����� �������� ������ �� ���������� �������";
		return NAN;
	}
	MATRIX minor(n - 1,n - 1);

	// ���������� ������� ������ �������
	for (int k = 0; k < n; k++)
	{
		for (int m = 0; m < n; m++)
		{
			if (k < i && m < j)
				*(minor.m_data + k * (n - 1) + m) = *(m_data + k * n + m);
			else if (k < i && m > j)
				*(minor.m_data + k * (n - 1) + m - 1) = *(m_data + k * n + m);
			else if (k > i && m < j)
				*(minor.m_data + (k - 1) * (n - 1) + m) = *(m_data + k * n + m);
			else if (k > i && m > j)
				*(minor.m_data + (k - 1) * (n - 1) + m - 1) = *(m_data + k * n + m);
		}
	}

	return minor.Determinant();
}
/// <summary>
/// ���������� �������� �������
/// </summary>
/// <returns></returns>
MATRIX MATRIX::Reverse()
{
	MATRIX A(m_rows, m_columns);
	if (m_rows != m_columns)
	{
		throw "��� ���������� �������� ������� �������� ������� ������ ���� ����������";
		return A;
	}
	double det = Determinant();
	
	if (abs(det) >= 1.0e-18)
	{
		auto Minors = [&](int row_begin, int row_end, int column_begin, int column_end)
			{
				for (int i = row_begin; i < row_end; i++)
					for (int j = column_begin; j < column_end; j++)
					{
						*(A.m_data + A.m_columns * i + j) = Minor(j, i) * pow(-1.0, i + j) / det;
					}
			};
		int size = A.m_rows;
		if (size >= MIN_SIZE_FOR_THREAD)
		{
			int size2 = size / 2;
			thread t1(Minors, 0, size2, 0, size2);
			thread t2(Minors, size2, size, 0, size2);
			thread t3(Minors, 0, size2, size2, size);
			thread t4(Minors, size2, size, size2, size);
			
			t1.join();
			t2.join();
			t3.join();
			t4.join();
		}
		else
			Minors(0, size, 0, size);
	}


	return A;
}
