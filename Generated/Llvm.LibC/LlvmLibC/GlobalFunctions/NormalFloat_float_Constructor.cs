using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEC2ENS0_6FPBitsIfEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<float>)")]
	public unsafe static void Invoke(fputil_NormalFloat_phu2qv* @this, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>")] int bits)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = bits;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs3, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
		NormalFloat_float_init_from_bits.Invoke(@this, fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEC2ENS_4SignEij")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned int)")]
	public unsafe static void Invoke(fputil_NormalFloat_phu2qv* @this, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte s, [NativeType("int")] int e, [NativeType("unsigned int")] int m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		anon_izyfb8.val = s;
		@this->exponent = e;
		@this->mantissa = m;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		unchecked
		{
			if ((uint)@this->mantissa < 8388608u)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_float_evaluate_normalization_shift.Invoke(@this, @this->mantissa);
				@this->mantissa <<= num;
				@this->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
