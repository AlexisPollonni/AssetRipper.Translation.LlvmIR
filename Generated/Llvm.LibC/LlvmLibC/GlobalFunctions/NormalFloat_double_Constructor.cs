using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdEC2ENS0_6FPBitsIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk* This, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long Bits)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = Bits;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
		NormalFloat_double_init_from_bits.Invoke(This, llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdEC2ENS_4SignEim")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk* This, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte S, [MangledName("e")][NativeType("int")] int E, [MangledName("m")][NativeType("unsigned long")] long M)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		anon_izyfb.Val = S;
		This->Exponent = E;
		This->Mantissa = M;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		unchecked
		{
			if ((ulong)This->Mantissa < 4503599627370496uL)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_double_evaluate_normalization_shift.Invoke(This, This->Mantissa);
				This->Mantissa <<= (int)(uint)num;
				This->Exponent -= num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
