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
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("bits.coerce0")] long Bits, [MangledName("bits.coerce1")] long Bits_coerce1)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		unchecked
		{
			*(long*)(&fputil_FPBits_ubgsi) = Bits;
			((long*)(&fputil_FPBits_ubgsi))[1] = Bits_coerce1;
			Llvm_memcpy_p0_p0_i64.Invoke(&((Fputil_NormalFloat_wqb3ie*)This)->Sign, Sign_POS.Pointer, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi2, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
			NormalFloat_long_double_init_from_bits.Invoke(This, *(long*)(&fputil_FPBits_ubgsi2), ((long*)(&fputil_FPBits_ubgsi2))[1]);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIeEC2ENS_4SignEio")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned __int128)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("s.coerce")] sbyte S, [MangledName("e")] int E, [MangledName("m.coerce0")] long M, [MangledName("m.coerce1")] long Normalization_shift)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		int num = 0;
		Int128 int2 = default(Int128);
		anon_izyfb.Val = S;
		unchecked
		{
			*(long*)(&@int) = M;
			((long*)(&@int))[1] = Normalization_shift;
			Int128 mantissa = @int;
			((Fputil_NormalFloat_wqb3ie*)This)->Exponent = E;
			((Fputil_NormalFloat_wqb3ie*)This)->Mantissa = mantissa;
			Llvm_memcpy_p0_p0_i64.Invoke(&((Fputil_NormalFloat_wqb3ie*)This)->Sign, &anon_izyfb, 1L, isVolatile: false);
			if (!NumericHelper.IntCmpUge(((Fputil_NormalFloat_wqb3ie*)This)->Mantissa, long.MinValue))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				int2 = ((Fputil_NormalFloat_wqb3ie*)This)->Mantissa;
				num = NormalFloat_long_double_evaluate_normalization_shift.Invoke(This, *(long*)(&int2), ((long*)(&int2))[1]);
				int num2 = num;
				Int128* mantissa2 = &((Fputil_NormalFloat_wqb3ie*)This)->Mantissa;
				*mantissa2 = NumericHelper.ShiftLeft(*mantissa2, (Int128)(UInt128)(uint)num2);
				((Fputil_NormalFloat_wqb3ie*)This)->Exponent -= num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
