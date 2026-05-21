using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEC2ENS0_6FPBitsIfEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<float>)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv* This, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>")] int Bits)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = Bits;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs, 4L, isVolatile: false);
		NormalFloat_float_init_from_bits.Invoke(This, llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEC2ENS_4SignEij")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv* This, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte S, [MangledName("e")][NativeType("int")] int E, [MangledName("m")][NativeType("unsigned int")] int M)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		anon_izyfb.Val = S;
		This->Exponent = E;
		This->Mantissa = M;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		unchecked
		{
			if ((uint)This->Mantissa < 8388608u)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_float_evaluate_normalization_shift.Invoke(This, This->Mantissa);
				This->Mantissa <<= num;
				This->Exponent -= num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
