using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EC2ENS0_6FPBitsIDF16_EE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<_Float16>)")]
internal static partial class fputil_NormalFloat_Float16_NormalFloat_fputil_FPBits_Float16
{
	public unsafe static void Invoke(fputil_NormalFloat_epbrnk* @this, [MangledName("bits.coerce")] short bits)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = bits;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva3, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
		fputil_NormalFloat_Float16_init_from_bits_fputil_FPBits_Float16.Invoke(@this, fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0);
	}
}
