using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIfEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::FPBits()")]
	public unsafe static void Invoke([MangledName("this")] Fputil_FPBits_5nkvcs* This)
	{
		FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(unchecked((Fputil_internal_FPRepImpl_vhj4tm*)This));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIfEC2IfEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::FPBits<float>(float)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_FPBits_5nkvcs* This, [MangledName("x")][NativeType("float")] float X)
	{
		float num = X;
		unchecked
		{
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)This);
			((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = Cpp_bit_cast_unsigned_int_float.Invoke(&num);
		}
	}
}
