using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIeEC2ENS0_6FPBitsIeEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<long double>)")]
internal static partial class fputil_NormalFloat_long_double_NormalFloat_fputil_FPBits_long_double
{
	public unsafe static void Invoke(void* @this, [MangledName("bits.coerce0")] long bits, [MangledName("bits.coerce1")] long bits_coerce1)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		unchecked
		{
			*(long*)(&fputil_FPBits_ubgsi3) = bits;
			((long*)(&fputil_FPBits_ubgsi3))[1] = bits_coerce1;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_NormalFloat_wqb3ie*)@this)->sign, Sign_POS.Pointer, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
			fputil_NormalFloat_long_double_init_from_bits_fputil_FPBits_long_double.Invoke(@this, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
		}
	}
}
