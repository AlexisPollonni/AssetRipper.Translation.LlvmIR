using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdEC2ENS0_6FPBitsIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	public unsafe static void Invoke(fputil_NormalFloat_vc4yvk* @this, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long bits)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = bits;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
		NormalFloat_double_init_from_bits.Invoke(@this, fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdEC2ENS_4SignEim")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned long)")]
	public unsafe static void Invoke(fputil_NormalFloat_vc4yvk* @this, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte s, [NativeType("int")] int e, [NativeType("unsigned long")] long m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		anon_izyfb8.val = s;
		@this->exponent = e;
		@this->mantissa = m;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		unchecked
		{
			if ((ulong)@this->mantissa < 4503599627370496uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_double_evaluate_normalization_shift.Invoke(@this, @this->mantissa);
				@this->mantissa <<= (int)(uint)num;
				@this->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
