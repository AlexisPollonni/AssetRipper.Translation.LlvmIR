using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strchr_implementation_true_82huui
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL21strchr_implementationILb1EEEPcPKci.200")]
	[DemangledName("char* __llvm_libc_20_1_2_::internal::strchr_implementation<true>(char const*, int) (.200)")]
	[CleanName("Internal_strchr_implementation_true")]
	[return: NativeType("char*")]
	public unsafe static void* Invoke([MangledName("src")][NativeType("char const*")] void* Src, [MangledName("c")][NativeType("int")] int C)
	{
		sbyte b = 0;
		void* ptr = null;
		void* ptr2 = Src;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			for (b = (sbyte)C; *(bool*)ptr2 && *(sbyte*)ptr2 != b; ptr2 = (byte*)ptr2 + 1)
			{
			}
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = null;
			void* result = ((*(sbyte*)ptr2 != b) ? ptr : ptr2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
