using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_13MessageMapperILm134ELm3113EE7get_strEi")]
[DemangledName("__llvm_libc_20_1_2_::MessageMapper<134ul, 3113ul>::get_str(int) const")]
internal static partial class MessageMapper_134ul_3113ul_get_str_int_const
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_bnt67x* agg_result, MessageMapper_8a2hs7* @this, int num)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			if (num >= 0 && (ulong)num < 134uL && ((int*)(&@this->msg_offsets))[num] != -1)
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
				cpp_string_view_string_view_char_const.Invoke(&cpp_string_view2, (byte*)(&@this->string_array) + ((int*)(&@this->msg_offsets))[num]);
				cpp_optional_cpp_string_view_optional_cpp_string_view.Invoke(agg_result, &cpp_string_view2);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			}
			else
			{
				llvm_memset_p0_i64.Invoke(agg_result, 0, 24L, isVolatile: false);
				cpp_optional_cpp_string_view_optional.Invoke(agg_result);
			}
		}
	}
}
