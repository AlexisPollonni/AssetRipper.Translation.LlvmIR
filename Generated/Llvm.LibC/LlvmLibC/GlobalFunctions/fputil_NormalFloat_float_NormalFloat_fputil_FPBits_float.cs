using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEC2ENS0_6FPBitsIfEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<float>)")]
internal static partial class fputil_NormalFloat_float_NormalFloat_fputil_FPBits_float
{
	public unsafe static void Invoke(fputil_NormalFloat_phu2qv* @this, [MangledName("bits.coerce")] int bits)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = bits;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs3, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
		fputil_NormalFloat_float_init_from_bits_fputil_FPBits_float.Invoke(@this, fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0);
	}
}
