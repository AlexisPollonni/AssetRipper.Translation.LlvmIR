using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal18complementary_spanEPKcS2_")]
[DemangledName("__llvm_libc_20_1_2_::internal::complementary_span(char const*, char const*)")]
internal static partial class internal_complementary_span_char_const_char_const
{
	public unsafe static long Invoke(void* src, void* segment)
	{
		void* ptr = null;
		cpp_array_jgy3xh cpp_array_jgy3xh2 = default(cpp_array_jgy3xh);
		void* ptr2 = src;
		void* ptr3 = segment;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = ptr2;
		llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh2);
		unchecked
		{
			sbyte* ptr4 = (sbyte*)(&cpp_array_jgy3xh2);
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			((long*)ptr4)[2] = -6148914691236517206L;
			((long*)ptr4)[3] = -6148914691236517206L;
			cpp_bitset_256ul_bitset.Invoke(&cpp_array_jgy3xh2);
			for (; *(bool*)ptr3; ptr3 = (byte*)ptr3 + 1)
			{
				cpp_bitset_256ul_set_unsigned_long.Invoke(&cpp_array_jgy3xh2, (byte)(*(sbyte*)ptr3));
			}
			for (; *(bool*)ptr2 && ((cpp_bitset_256ul_test_unsigned_long_const.Invoke(&cpp_array_jgy3xh2, (byte)(*(sbyte*)ptr2)) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0; ptr2 = (byte*)ptr2 + 1)
			{
			}
			long result = (long)ptr2 - (long)ptr;
			llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
