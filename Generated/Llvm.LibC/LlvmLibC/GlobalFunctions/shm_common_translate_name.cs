using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class shm_common_translate_name
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10shm_common14translate_nameENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::shm_common::translate_name(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_hnriuf* agg_result, [MangledName("name.coerce0")] void* name, [MangledName("name.coerce1")] long offset)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num = 0L;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		cpp_array_knc3mr cpp_array_knc3mr2 = default(cpp_array_knc3mr);
		unchecked
		{
			*(void**)(&cpp_string_view2) = name;
			((long*)(&cpp_string_view2))[1] = offset;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = string_view_find_first_not_of.Invoke(&cpp_string_view2, 47, 0L);
			if (num == -1L)
			{
				Errno_Assignment.Invoke(libc_errno.Pointer, 22);
				optional_cpp_array_char_265ul_Constructor.Invoke(agg_result);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
				Struct_kqhe8i struct_kqhe8i = string_view_substr.Invoke(&cpp_string_view2, num, -1L);
				cpp_string_view* num2 = &cpp_string_view3;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num2 = struct_kqhe8i2.field_0;
				byte* num3 = (byte*)(&cpp_string_view3) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num3 = struct_kqhe8i3.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view3, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
				if ((ulong)string_view_size.Invoke(&cpp_string_view2) > 255uL)
				{
					Errno_Assignment.Invoke(libc_errno.Pointer, 36);
					optional_cpp_array_char_265ul_Constructor.Invoke(agg_result);
				}
				else
				{
					string_view_Constructor.Invoke(&cpp_string_view4, str_111.Pointer);
					if (!string_view_Equals.Invoke(&cpp_string_view2, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]))
					{
						string_view_Constructor.Invoke(&cpp_string_view5, str_1_112.Pointer);
						if (!string_view_Equals.Invoke(&cpp_string_view2, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]) && !string_view_contains.Invoke(&cpp_string_view2, 47))
						{
							llvm_lifetime_start_p0.Invoke(265L, &cpp_array_knc3mr2);
							llvm_memset_p0_i64.Invoke(&cpp_array_knc3mr2, -86, 265L, isVolatile: false);
							inline_memcpy.Invoke(array_char_265ul_data.Invoke(&cpp_array_knc3mr2), string_view_data.Invoke(shm_common_SHM_PREFIX.Pointer), string_view_size.Invoke(shm_common_SHM_PREFIX.Pointer));
							inline_memcpy.Invoke((byte*)array_char_265ul_data.Invoke(&cpp_array_knc3mr2) + string_view_size.Invoke(shm_common_SHM_PREFIX.Pointer), string_view_data.Invoke(&cpp_string_view2), string_view_size.Invoke(&cpp_string_view2));
							*(sbyte*)array_char_265ul_Index.Invoke(&cpp_array_knc3mr2, string_view_size.Invoke(shm_common_SHM_PREFIX.Pointer) + string_view_size.Invoke(&cpp_string_view2)) = 0;
							optional_cpp_array_char_265ul_Constructor.Invoke(agg_result, &cpp_array_knc3mr2);
							llvm_lifetime_end_p0.Invoke(265L, &cpp_array_knc3mr2);
							goto IL_0234;
						}
					}
					Errno_Assignment.Invoke(libc_errno.Pointer, 22);
					optional_cpp_array_char_265ul_Constructor.Invoke(agg_result);
				}
			}
			goto IL_0234;
		}
		IL_0234:
		llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
