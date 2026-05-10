using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat()")]
internal static partial class fputil_DyadicFloat_64ul_DyadicFloat
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->sign, Sign_POS.Pointer, 1L, isVolatile: false);
			((fputil_DyadicFloat_374hpp*)@this)->exponent = 0;
			BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa, 0);
		}
	}
}
