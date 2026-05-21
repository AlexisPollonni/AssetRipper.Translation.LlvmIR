using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIeEC2ENS0_6FPBitsIeEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<long double>)")]
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
			NormalFloat_long_double_init_from_bits.Invoke(@this, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIeEC2ENS_4SignEio")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned __int128)")]
	public unsafe static void Invoke(void* @this, [MangledName("s.coerce")] sbyte s, int e, [MangledName("m.coerce0")] long m, [MangledName("m.coerce1")] long normalization_shift)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		int num = 0;
		Int128 int2 = default(Int128);
		anon_izyfb8.val = s;
		unchecked
		{
			*(long*)(&@int) = m;
			((long*)(&@int))[1] = normalization_shift;
			Int128 mantissa = @int;
			((fputil_NormalFloat_wqb3ie*)@this)->exponent = e;
			((fputil_NormalFloat_wqb3ie*)@this)->mantissa = mantissa;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_NormalFloat_wqb3ie*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			if (!NumericHelper.IntCmpUge(((fputil_NormalFloat_wqb3ie*)@this)->mantissa, long.MinValue))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				int2 = ((fputil_NormalFloat_wqb3ie*)@this)->mantissa;
				num = NormalFloat_long_double_evaluate_normalization_shift.Invoke(@this, *(long*)(&int2), ((long*)(&int2))[1]);
				int num2 = num;
				Int128* mantissa2 = &((fputil_NormalFloat_wqb3ie*)@this)->mantissa;
				*mantissa2 = NumericHelper.ShiftLeft(*mantissa2, (Int128)(UInt128)(uint)num2);
				((fputil_NormalFloat_wqb3ie*)@this)->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
