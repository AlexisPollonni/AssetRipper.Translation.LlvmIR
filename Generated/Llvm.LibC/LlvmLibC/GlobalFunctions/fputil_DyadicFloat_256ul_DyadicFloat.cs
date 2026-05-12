using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::DyadicFloat()")]
internal static partial class fputil_DyadicFloat_256ul_DyadicFloat
{
	public unsafe static void Invoke(fputil_DyadicFloat_jhcpjj* @this)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		@this->exponent = 0;
		BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&@this->mantissa, 0);
	}
}
