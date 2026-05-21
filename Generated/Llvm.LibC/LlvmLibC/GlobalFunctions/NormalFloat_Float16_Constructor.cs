using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EC2ENS0_6FPBitsIDF16_EE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<_Float16>)")]
	public unsafe static void Invoke(fputil_NormalFloat_epbrnk* @this, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>")] short bits)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = bits;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva3, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
		NormalFloat_Float16_init_from_bits.Invoke(@this, fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EC2ENS_4SignEit")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned short)")]
	public unsafe static void Invoke(fputil_NormalFloat_epbrnk* @this, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte s, [NativeType("int")] int e, [NativeType("unsigned short")] short m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		anon_izyfb8.val = s;
		short mantissa = m;
		@this->exponent = e;
		@this->mantissa = mantissa;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		unchecked
		{
			if ((ushort)@this->mantissa < 1024)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_Float16_evaluate_normalization_shift.Invoke(@this, @this->mantissa);
				int num2 = num;
				short* mantissa2 = &@this->mantissa;
				*mantissa2 = (short)((ushort)(*mantissa2) << num2);
				@this->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
