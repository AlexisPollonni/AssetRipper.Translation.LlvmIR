using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false
{
	[MangledName("_ZN19__llvm_libc_20_1_2_18StrictIntegralTypeIjEC2IjTnNS_3cpp9enable_ifIXsr3cppE9is_same_vIT_jEEbE4typeELb0EEES5_")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<unsigned int>::StrictIntegralType<unsigned int, false>(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("unsigned int")] int Value)
	{
		unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = Value;
	}
}
