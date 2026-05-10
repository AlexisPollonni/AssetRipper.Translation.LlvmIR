using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIeEC2ENS_4SignEio")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned __int128)")]
internal static partial class fputil_NormalFloat_long_double_NormalFloat_Sign_int_unsigned_int128
{
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
				num = fputil_NormalFloat_long_double_evaluate_normalization_shift_unsigned_int128.Invoke(@this, *(long*)(&int2), ((long*)(&int2))[1]);
				int num2 = num;
				Int128* mantissa2 = &((fputil_NormalFloat_wqb3ie*)@this)->mantissa;
				*mantissa2 = NumericHelper.ShiftLeft(*mantissa2, (Int128)(UInt128)(uint)num2);
				((fputil_NormalFloat_wqb3ie*)@this)->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
