using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_strchr_implementation_true_d3u7r6
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL21strchr_implementationILb1EEEPcPKci")]
	[DemangledName("char* __llvm_libc_20_1_2_::internal::strchr_implementation<true>(char const*, int)")]
	[CleanName("internal_strchr_implementation_true")]
	[return: NativeType("char*")]
	public unsafe static void* Invoke([NativeType("char const*")] void* src, [NativeType("int")] int c)
	{
		sbyte b = 0;
		void* ptr = null;
		void* ptr2 = src;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			for (b = (sbyte)c; *(bool*)ptr2 && *(sbyte*)ptr2 != b; ptr2 = (byte*)ptr2 + 1)
			{
			}
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = null;
			void* result = ((*(sbyte*)ptr2 != b) ? ptr : ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
