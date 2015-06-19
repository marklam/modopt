#pragma once

namespace CxxCLI {

	public ref class Base abstract
	{
		public:
			virtual long GetLong() = 0;
			virtual int  GetInt() = 0;
	};

	public ref class CxxDerived : public Base
	{
		public:
			virtual long GetLong() override { return 1; }
			virtual int  GetInt()  override { return 2; }
	};
}
